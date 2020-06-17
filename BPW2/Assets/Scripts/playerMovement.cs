using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    
    

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, 1500 * Time.deltaTime);
    }
}
