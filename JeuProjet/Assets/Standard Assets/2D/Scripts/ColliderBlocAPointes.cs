using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderBlocAPointes : MonoBehaviour
{
    public GameObject blocPointes;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            blocPointes.GetComponent<Rigidbody2D>().isKinematic = false;

        }

    }
}