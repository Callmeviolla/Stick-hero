using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StickGrows : MonoBehaviour
{


    public GameObject stick;
    private bool isAnimated;
    private int count = 0;


    void FixedUpdate()
    {
        if(isAnimated && count<2)
        {
            stick.transform.localPosition += new Vector3(0f, 0.7f * Time.deltaTime);
            stick.transform.localScale += new Vector3(0f, 1.4f * Time.deltaTime);
            stick.GetComponent<AudioSource>().Play();
        }
        
    }


    void OnMouseDown()
    { 
        isAnimated = true;
    }


    void OnMouseUp()
    {
        isAnimated = false;
        count++;
    }
}
