using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 8f;
    public float jumpFoce = 10f;
    public float jumpHoldForce = 1.3f;
    public float jumpHoldDuration = 0.1f;

    float jumpTime;

    bool grounded = true;
    public Transform Groundcheck;
    bool isJump;
    float checkradius = 0.1f;
    public LayerMask whatisground;

    bool jumpPressed;
    bool jumpHeld;
    

    float xVelocity;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        

    }

    void Update()
    {
        jumpPressed = Input.GetButtonDown("Jump");
        jumpHeld = Input.GetButton("Jump");
    }
    private void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(Groundcheck.position, checkradius, whatisground);
        GroundMovement();
        Airmovenment();

    }


   void Airmovenment()
    {
        if(jumpPressed&&grounded&&!isJump)
        {
            grounded = false;
            isJump=true;
            jumpTime = Time.time + jumpHoldDuration;
            rb.AddForce(new Vector2(0, jumpFoce));
        }
        else if(isJump)
    {
        if (jumpHeld)
            rb.AddForce(new Vector2(0, jumpFoce));
        if (jumpTime < Time.time)
            isJump = false;
    }

    
    

    }
    void GroundMovement()
    {
           transform.Translate(Vector3.left * speed * Time.deltaTime);
        FilDirction();
    }
    void FilDirction()
    {
        if (xVelocity < 0)
            transform.localScale = new Vector2(-1, 1);
        if (xVelocity > 0)
            transform.localScale = new Vector2(1, 1);
    }
}
