﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSplitter : Singleton<CameraSplitter>
{
    public List<Camera> cameras;
    // Start is called before the first frame update
    void Start()
    {
        if (cameras.Count == 1)
        {
            cameras[0].rect = new Rect(0, 0, 1, 1);
        }
        else
        {
            cameras[0].rect = new Rect(0, 0, 1, 0.5f);
            cameras[1].rect = new Rect(0, 0.5f, 1, 0.5f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
