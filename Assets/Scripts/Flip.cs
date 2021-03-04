using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Flip : MonoBehaviour
{
    private bool m_FacingRight = true;
    private Vector3 theScale;
    public Joystick joystick;
    private float movement = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement = CrossPlatformInputManager.GetAxis("Horizontal");


        if (movement > 0 && !m_FacingRight)
        {
            
            // ... flip the player.
            m_FacingRight = !m_FacingRight;

            // Multiply the player's x local scale by -1.
            theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
        // Otherwise if the input is moving the player left and the player is facing right...
        else if (movement < 0 && m_FacingRight)
        {
            
            // ... flip the player.
            m_FacingRight = !m_FacingRight;

            // Multiply the player's x local scale by -1.
            theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
    }
   
}
