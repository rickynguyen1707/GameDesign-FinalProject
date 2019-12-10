using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowball : MonoBehaviour
{
    private float moveSpeed = 7f;
    private GameObject target;
    private Vector2 moveDirection;
    private Vector3 targetPosition;
    private Vector3 dir;
    private bool facingRight = false;
    private float angle;
    Rigidbody2D rgbd;

    
    // Start is called before the first frame update
    void Start()
    {
        rgbd = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player");
        moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
        rgbd.velocity = new Vector2(moveDirection.x, moveDirection.y);
        Destroy(gameObject, 5f);
        //Transform snowball direction to follow player
        targetPosition = target.transform.position;
        dir = targetPosition - this.transform.position;
        angle = Mathf.Atan2(-dir.y, -dir.x) * Mathf.Rad2Deg;
        this.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        /*if (Vector3.Distance(target.transform.position, transform.position) < 20)
        {
            if (target.transform.position.x > transform.position.x && !facingRight)// if the target is to the right of enemy and enemy is not facing right
                Flip();
            if (target.transform.position.x < transform.position.x && facingRight)
                Flip();
        }*/
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag.Equals("Player"))
        {
            Destroy(col.gameObject);
            Destroy(this.gameObject);
            Gameover.Instance.SendGameover();
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    void Flip()
    {
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
        facingRight = !facingRight;
    }
}
