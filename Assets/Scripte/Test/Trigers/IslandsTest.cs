﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IslandsTest : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.name == "Player")
        {
            co.transform.parent = null;
        }
    }
}
