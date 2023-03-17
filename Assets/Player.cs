using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float test; 
    public bool grounded;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        test = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump") && grounded == true) 
        {
             rb.AddForce(transform.up * 1800);
        }
    }
    void FixedUpdate()
    {
         rb.AddForce(transform.right * test * 5);
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "ground")
        {
            grounded = true;
        } 
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "ground")
        {
            grounded = false;
        }
    }
}
