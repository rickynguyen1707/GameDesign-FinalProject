using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level4To5 : MonoBehaviour
{
    public GameObject Player;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject == Player)
        {
            col.transform.position = new Vector3(148.5f, 11.5f, 0);
        }
    }
}
