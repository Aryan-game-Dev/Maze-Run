using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    float x,
          z;
    bool jumpKeyWasPressed,
         isGrounded;

    [SerializeField] float moveSensi = 10,
                           jumpForce = 5;

    Rigidbody rb;

    public AudioSource AS;
    public AudioClip jump, bump, wall; 

      void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }


    void Update()
    {
        x = Input.GetAxis("Horizontal") * Time.deltaTime * moveSensi;
        z = Input.GetAxis("Vertical") * Time.deltaTime * moveSensi;

        transform.Translate(x, 0, z);


        if (Input.GetButtonDown("Jump"))
        {
            jumpKeyWasPressed = true;
        }
    }

     void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground") 
            || collision.gameObject.CompareTag ("Walls") 
            || collision.gameObject.CompareTag("start") 
            || collision.gameObject.CompareTag("Obstacle"))
        {
            isGrounded = true;
        }

        else
        {
            isGrounded = false;
        }

        if(collision.gameObject.CompareTag("Obstacle"))
        {
            int Sceneindex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(Sceneindex);


            AS.clip = bump;
            AS.Play();
        }
         
        if(collision.gameObject.CompareTag("Walls"))
        {
            AS.clip = wall;
            AS.Play();
        }
    }

    void FixedUpdate()
    {
        if (jumpKeyWasPressed && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce , ForceMode.VelocityChange )  ;
            jumpKeyWasPressed = false;
            isGrounded = false;

            AS.clip = jump;
            AS.Play();
        }
    }
}
