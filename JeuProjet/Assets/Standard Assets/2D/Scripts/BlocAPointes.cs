using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlocAPointes : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            Debug.Log("blocpointes");
            SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
        }
    }
}