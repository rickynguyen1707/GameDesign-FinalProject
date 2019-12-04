using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowball : MonoBehaviour
{
    private float moveSpeed = 7f;
    private GameObject target;
    private Vector2 moveDirection;
    Rigidbody2D rgbd;

    
    // Start is called before the first frame update
    void Start()
    {
        rgbd = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player");
        moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
        rgbd.velocity = new Vector2(moveDirection.x, moveDirection.y);
        Destroy(gameObject, 5f);
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
