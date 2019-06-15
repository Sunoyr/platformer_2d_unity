using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class TeleporterScript : MonoBehaviour
{

    public string NomLevel;

    private void Start()
    {
        if(SceneManager.GetActiveScene().name == "Monde1_1")
        {
            PlayerPrefs.SetInt("Score", 0);
        }

        Debug.Log(PlayerPrefs.GetInt("Score"));
        var text = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>().text = PlayerPrefs.GetInt("Score").ToString();


    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            var text = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>();
            var oldscore = int.Parse(text.text);
            PlayerPrefs.SetInt("Score", oldscore);

            SceneManager.LoadScene(NomLevel);
        }
    }
}

