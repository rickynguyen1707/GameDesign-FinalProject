using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3To4 : MonoBehaviour
{
    public GameObject Player;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject == Player)
        {
            col.transform.position = new Vector3(107.5f, 12.5f, 0);
        }
    }
}
