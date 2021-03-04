using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GOAL : MonoBehaviour {

    public GameObject level_complete;

    public int unlock;
    private GameObject[] Virus;

    void Start ()
    {
        Time.timeScale = 1;

        unlock = SceneManager.GetActiveScene().buildIndex + 1;

        level_complete.SetActive(false);


    }
    void Update()
    {
        Virus = GameObject.FindGameObjectsWithTag("Virus");
        if (Virus == null)
        {
            PlayerPrefs.SetInt("levelReached", unlock);
            level_complete.SetActive(true);
            Debug.Log(Virus);
        }
    }

     
}
