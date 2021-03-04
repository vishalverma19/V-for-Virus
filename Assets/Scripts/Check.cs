using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Check : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public float speed = 2f;
    public static bool isFired;
     
    void Start()
    {
        isFired = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump")|| CrossPlatformInputManager.GetButtonDown("Jump"))
        {
            FindObjectOfType<AudioManager>().Play("Shot");
            isFired = true;
        }
        if (isFired)
        {
            transform.localScale = transform.localScale + Vector3.up * Time.deltaTime*speed;
        }
        else
        {

            transform.position = player.position;
            transform.localScale = new Vector3(1f, 0f, 1f);
        }
    }
}
