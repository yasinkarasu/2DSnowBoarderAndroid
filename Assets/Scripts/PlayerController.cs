// using UnityEngine;

// public class PlayerController : MonoBehaviour
// {
// [SerializeField] float torqueAmount = 1f;
// Rigidbody2D rb2d;
    
//     // Start is called once before the first execution of Update after the MonoBehaviour is created
//    void Start()
//     {
//         rb2d = GetComponent<Rigidbody2D>();
//     }

//      // Update is called once per frame
//     void Update()
//     {
//         if(Input.GetKey(KeyCode.LeftArrow))
//         {
//              rb2d.AddTorque(torqueAmount);
//         }
//          else if(Input.GetKey(KeyCode.RightArrow))
//         {
//              rb2d.AddTorque(-torqueAmount);
//         }
//     }
// }

using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    [SerializeField] float torqueAmount = 1f;
    [SerializeField] private DynamicJoystick joystick;
     Rigidbody2D rb2d;
    
     void Start()
    {
         rb2d = GetComponent<Rigidbody2D>();
    }
   
        void Update()
    {
    // Joystick'in yatay eksen değerini büyüterek hassasiyeti artır
        float horizontalInput = joystick.Horizontal * 5f; 

        if (horizontalInput < 0)
        {
        rb2d.AddTorque(torqueAmount * Mathf.Abs(horizontalInput));
        }
        else if (horizontalInput > 0)
        {
        rb2d.AddTorque(-torqueAmount * Mathf.Abs(horizontalInput));
        }
    }

}
