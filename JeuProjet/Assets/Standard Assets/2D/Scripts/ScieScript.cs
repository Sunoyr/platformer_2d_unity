using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ScieScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            Debug.Log("ofjhgpoedr");
            SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
        }
    }

    private void Update()
    {
        transform.Rotate(0, 0, 5);
    }
}
