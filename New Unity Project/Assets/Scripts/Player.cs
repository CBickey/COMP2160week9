﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;

    public int coinsGathered;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal")*Time.deltaTime*speed,0f , Input.GetAxis("Vertical")*Time.deltaTime*speed);
    }

    private void OnTriggerEnter(Collider collision)
    {
        {
            coinsGathered++;
        }
    }
}
