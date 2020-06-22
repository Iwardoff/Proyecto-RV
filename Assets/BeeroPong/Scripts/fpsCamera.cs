using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsCamera : MonoBehaviour
{
    public Camera FPSCam;

    public float velHor;
    public float velVer;

    float h;
    float v;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        h = velHor * Input.GetAxis("Mouse X");
        v = velVer * Input.GetAxis("Mouse Y");

        transform.Rotate (-v,h,0);
    }
}
