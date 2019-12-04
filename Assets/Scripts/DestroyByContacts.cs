﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContacts : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {

        // Destroy the "other" object and destroy this asteroid
        Destroy(other.gameObject);
        Gameover.Instance.SendGameover();
    }
}
