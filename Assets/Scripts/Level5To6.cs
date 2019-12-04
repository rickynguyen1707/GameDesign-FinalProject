using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level5To6 : MonoBehaviour
{
    public GameObject Player;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject == Player)
        {
            col.transform.position = new Vector3(163, 9.5f, 0);
        }
    }
}
