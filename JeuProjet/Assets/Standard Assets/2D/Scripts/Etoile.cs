using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Etoile : MonoBehaviour
{
    bool pris = true;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player") && pris)
        {
            Destroy(gameObject);
            var text = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>();
            var oldscore = int.Parse(text.text);
            text.text = (oldscore + 10).ToString();
            pris = false;
        }
    }
}
