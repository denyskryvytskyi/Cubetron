using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    
    public float forwardForce = 1f;
    public float horizontalForce = 10f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(Input.GetAxisRaw("Horizontal") * horizontalForce * Time.deltaTime, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        
        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
