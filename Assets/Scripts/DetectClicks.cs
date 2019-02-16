using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DetectClicks : MonoBehaviour
{


    public Text gameName;
    public GameObject buttonPlay, audioButton,mainCube,secondCube,stick;
    private bool isClicked;
    private Vector3 stickPos;
    NewCube script;


    void OnMouseDown()
    {
        if (!isClicked)
        {
            isClicked = true;
            gameName.text = "0";
            audioButton.gameObject.SetActive(false);
            buttonPlay.GetComponent<AudioSource>().Play();
            buttonPlay.gameObject.SetActive(false);
            mainCube.GetComponent<Animation>().Play("StartGame");
            stickPos = new Vector3(-1.45f,-7.4f,0.7f);
            stick.transform.SetPositionAndRotation(stickPos, Quaternion.identity);
            script = secondCube.GetComponent<NewCube>();
            script.enabled = true;
            
        }
    }
}
