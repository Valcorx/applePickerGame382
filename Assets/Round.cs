﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Round : MonoBehaviour
{
    public int round = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        round = ApplePicker.round;
        Text gt = this.GetComponent<Text>();
        gt.text = "Round: " + round;

    }
}
