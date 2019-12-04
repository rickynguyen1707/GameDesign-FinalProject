﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snowflakesmove : MonoBehaviour
{
    public float speed = 20.0f;

    private Rigidbody2D rBody;

    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
        rBody.velocity = Vector2.down * speed;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(this.gameObject); // Destroy the entire game object
    }
}
