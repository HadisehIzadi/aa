using UnityEngine;

public class CatController : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 8f;
    public Joystick joystick;
    
    public GameManager gameManager;

    private Rigidbody2D rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true; 

    }

    void Update()
    {

        float moveX = joystick.Horizontal;
        float moveY = joystick.Vertical;



        rb.velocity = new Vector2(moveX * speed, rb.velocity.y);


        if (moveX > 0.1f)
            transform.localScale = new Vector3(7, 7, 1);

        else if (moveX < -0.1f)
            transform.localScale = new Vector3(-7, 7, 1);


        if (moveY > 0.5f && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            isGrounded = false;
        }


        if (transform.position.y <= -5f)
            gameManager.GameOver();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Debug.Log("enter step");
            isGrounded = true;
        }
        if (collision.gameObject.CompareTag("Fire"))
        {
        	gameManager.GameOver();
        }
        
        
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Debug.Log("exit step");
            isGrounded = false;
        }
    }
}
