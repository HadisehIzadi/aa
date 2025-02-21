using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerExample : MonoBehaviour
{
    public float speed;
    public VariableJoystick variableJoystick;
    public Rigidbody rb;

    public void FixedUpdate()
    {
        Vector3 direction = Vector3.forward * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal;
        rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
    }


// public float speed = 5f;
//    public VariableJoystick variableJoystick;
//    public Rigidbody2D rb;
//
//    private void FixedUpdate()
//    {
//        // دریافت جهت حرکت از جوی‌استیک
//        Vector2 direction = new Vector2(variableJoystick.Horizontal, variableJoystick.Vertical);
//        
//        // اعمال نیرو برای حرکت در جهت جوی‌استیک
//        rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode2D.Impulse);
//    }
}



