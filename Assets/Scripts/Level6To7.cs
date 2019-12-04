using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level6To7 : MonoBehaviour
{
    public GameObject Player;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject == Player)
        {
            col.transform.position = new Vector3(202.5f, 10.5f, 0);
        }
    }
}
