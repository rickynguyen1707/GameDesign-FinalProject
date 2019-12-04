using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    private Transform target;
    private bool facingRight = false;
    public GameObject snowball;
    private float fireRate;
    private float nextFire;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        fireRate = 1f;
        nextFire = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(target.position, transform.position) < 20)
        {
            if (target.position.x > transform.position.x && !facingRight)// if the target is to the right of enemy and enemy is not facing right
                Flip();
            if (target.position.x < transform.position.x && facingRight)
                Flip();
        }
        CheckIfTimeToFire();
    }
    void Flip()
    {
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
        facingRight = !facingRight;
    }
    void CheckIfTimeToFire()
    {
        if (Time.time > nextFire)
        {
            Instantiate(snowball, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }
    }
}
