using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AudioButton : MonoBehaviour
{

    public Sprite musOn, musOff;


    void OnMouseUpAsButton()
    {
        if(gameObject.name == "Audio")
        {
            if(PlayerPrefs.GetString ("Music") == "off")
            {
                GetComponent <Image>().sprite = musOn;
                PlayerPrefs.GetString("Music", "on");
            }
            else
            {
                GetComponent<Image>().sprite = musOff;
                PlayerPrefs.GetString("Music", "off");
            }
            if (PlayerPrefs.GetString("Music") == "on")
            {
                GetComponent<Image>().sprite = musOff;
                PlayerPrefs.GetString("Music", "off");
            }
            else
            {
                GetComponent<Image>().sprite = musOn;
                PlayerPrefs.GetString("Music", "on");
            }
        }
    }
}
