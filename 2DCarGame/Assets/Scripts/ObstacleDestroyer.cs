﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDestroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D withObject)
    {
        print("Collision with " + withObject.name);
    }
}