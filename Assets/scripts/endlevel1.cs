using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endlevel1 : MonoBehaviour
{
    public GameObject endpanel;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("endlevel"))
        {
            endpanel.SetActive(true);
            Time.timeScale = 0;
        }

    }
    public void Menu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
}
