using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameWon : MonoBehaviour
{
    public GameObject gamewon;
    void Start()
    {
        gamewon.SetActive(false);
    }
    public void PlayerWon()
    {
        gamewon.SetActive(true);
        FindObjectOfType<AudioManager>().Play("Win");
    }
    public void NextLevel()
    {
        SceneManager.LoadScene("Level_Menu");
    }
}
