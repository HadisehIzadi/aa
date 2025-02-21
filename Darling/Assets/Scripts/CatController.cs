using UnityEngine;

public class CatController : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 8f;
    public Joystick joystick; // Joystick رو از Inspector به این متغیر وصل کن
    private Rigidbody2D rb;
    private bool isGrounded = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // دریافت مقدار ورودی از جوی‌استیک
        float moveX = joystick.Horizontal;
        float moveY = joystick.Vertical; // مقدار عمودی جوی‌استیک

        // تنظیم سرعت حرکت
        rb.velocity = new Vector2(moveX * speed, rb.velocity.y);

        // چرخش گربه به سمت راست یا چپ
        if (moveX > 0.1f)
            transform.localScale = new Vector3(6, 6, 6);
        else if (moveX < -0.1f)
            transform.localScale = new Vector3(-6, 6, 6);

        // پرش با جوی‌استیک (اگر جوی‌استیک به سمت بالا کشیده شد و روی زمین هست)
        if (moveY > 0.5f && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
         //   isGrounded = false;
        }
    }

//    void OnCollisionEnter2D(Collision2D collision)
//    {
//        if (collision.gameObject.CompareTag("Ground"))
//        {
//            isGrounded = true;
//        }
//    }
//
//    void OnCollisionExit2D(Collision2D collision)
//    {
//        if (collision.gameObject.CompareTag("Ground"))
//        {
//            isGrounded = false;
//        }
//    }
}
