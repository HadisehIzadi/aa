using UnityEngine;

public class LostMessage : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) // بررسی اینکه کاراکتر بازیکن پیام را لمس کرده
        {
        	int messageCount = PlayerPrefs.GetInt("messageCount" , 0 );
        	int IncreaseMessageCount = messageCount + 1000 ;
        	PlayerPrefs.SetInt("messageCount" , IncreaseMessageCount);
            Destroy(gameObject); // حذف پیام بعد از جمع‌آوری
        }
    }
}
