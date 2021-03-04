using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using GoogleMobileAds.Api;
using UnityEngine.Video;

public class Intro : MonoBehaviour
{
    public float wait_time = 5f;
    public VideoPlayer VP;
    string App_ID = "ca-app-pub-5525459778742556~3517226618";
    // Start is called before the first frame update
    void Start()
    {
        MobileAds.Initialize(App_ID);
        StartCoroutine(Wait_for_intro());
    }

    IEnumerator Wait_for_intro()
    {
        yield return new WaitForSeconds(wait_time);
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
