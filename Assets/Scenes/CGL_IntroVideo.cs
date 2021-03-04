using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using GoogleMobileAds.Api;
using System;

public class CGL_IntroVideo : MonoBehaviour
{
    public RawImage RI;
    public VideoPlayer VP;
    public Animator A;
    public float waitTime;
    string App_ID = "ca-app-pub-5525459778742556~3517226618";

    void Start()
    {
        MobileAds.Initialize(App_ID);
        StartCoroutine(PlayVideo());
        StartCoroutine(fadeout());
    }
    IEnumerator PlayVideo()
    {
        VP.Prepare();
        while(!VP.isPrepared)
        {
            yield return new WaitForSeconds(1f);
            break;
        }
       
        RI.texture = VP.texture;
        VP.Play();
    }
    IEnumerator fadeout()
    {
        yield return new WaitForSeconds(waitTime);
        A.SetTrigger("FadeOut");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Menu");
    }
}
