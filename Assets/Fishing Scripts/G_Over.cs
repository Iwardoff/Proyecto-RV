﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class G_Over : MonoBehaviour
{
    public GameObject Panel;
    public GameObject GameOv;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Timer_Script.CurrentTime <= 0)
        {
            Panel.SetActive(true);
            GameOv.SetActive(true);


        }
    }
}
