using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using GoogleMobileAds.Api;
public class movie : MonoBehaviour
{
    string App_ID = "ca-app-pub-5525459778742556~3517226618";
    //public RawImage raw;
    //public VideoPlayer vp;
    //public 
    // Start is called before the first frame update
    void Start()
    {
        MobileAds.Initialize(App_ID);
        //((MovieTexture)GetComponent<Renderer>().material.mainTexture).Play();
        StartCoroutine(pla());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator pla()
    {
      yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(1);
    }
}
