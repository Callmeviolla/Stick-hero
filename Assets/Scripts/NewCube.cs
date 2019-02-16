using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewCube : MonoBehaviour
{


    public GameObject cube;
    private Vector3 cubePos;
    

    void Start()
    {
        cubePos = new Vector3(Random.Range(0.1f, 1.7f), -4.6f, -9.2f);
        cube.transform.localScale = new Vector3(Random.Range(0.5f, 2f), cube.transform.localScale.y, cube.transform.localScale.z);
    }
    

    void Update()
    {
        if (cube.transform.position != cubePos)
            cube.transform.position = Vector3.MoveTowards(cube.transform.position, cubePos, Time.deltaTime*6);
    }
}
