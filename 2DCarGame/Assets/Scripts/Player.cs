﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//Moving the car to the left and right on the x-axis
public class Player : MonoBehaviour
{ 
//These variables can be added  on unity 
    [SerializeField] float moveSpeed = 0.02f;



    [SerializeField] float padding = 0.7f;



    float xMin, xMax, yMin, yMax;



    // Start is called 
    void Start()
    {
        ToSetBoundaries();
    }



    // Update is called once per frame
    void Update()
    {
        ToMove();
    }



    //The car dosen't overlap the camera 
    private void ToSetBoundaries()
    { 
        Camera gameCamera = Camera.main;



        //The car dosen't overlap into the x and y axis in position of the camera

        xMin = gameCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x + padding;
        xMax = gameCamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x - padding;



        yMin = gameCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y + padding;
        yMax = gameCamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y - padding;
    }



    //To move the car 
    private void ToMove()
    {

        var deltaX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed; //for the car to move horizontal



        var newXPos = transform.position.x + deltaX;




        newXPos = Mathf.Clamp(newXPos, xMin, xMax);



        this.transform.position = new Vector2(newXPos, transform.position.y);
    }
}


