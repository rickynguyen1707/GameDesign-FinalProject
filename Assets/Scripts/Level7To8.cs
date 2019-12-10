using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level7To8 : MonoBehaviour
{
    public GameObject Player;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject == Player)
        {
            col.transform.position = new Vector3(273.5f, 12f, 0);
        }
    }
}
