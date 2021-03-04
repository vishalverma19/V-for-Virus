using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameover;
    

    void Start()
    {
        gameover.SetActive(false);
    }
    public void PlayerDie()
    {
        StartCoroutine(Die());
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    IEnumerator Die()
    {
        yield return new WaitForSeconds(3f);
        gameover.SetActive(true);
    }
}
