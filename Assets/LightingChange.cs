using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using UnityEngine.Networking;
using Vuforia;

public class LightingChange : MonoBehaviour
{
    public GameObject MergeCube;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Update", 0f, 10f); 
    }

    // Update is called once per frame
    void Update()
    {
        UnityEngine.Vector3 degree = MergeCube.transform.eulerAngles;
        if (degree.x >= 180 || degree.z >= 180){
        Debug.Log("DEGREE is " + degree);
        }
    }
}
