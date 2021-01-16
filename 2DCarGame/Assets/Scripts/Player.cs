using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//Moving the car to the left and right on the x-axis
public class Player : MonoBehaviour
{ 
//These variables can be added  on unity 
    [SerializeField] float moveSpeed = 0.02f;



    [SerializeField] float padding = 0.7f;

    [SerializeField] float playerHealth = 100;

    [SerializeField] AudioClip playerDeathSound;
    [SerializeField] [Range(0, 1)] float playerDeathSoundVolume = 0.75f;

    [SerializeField] AudioClip shootSound;
    [SerializeField] [Range(0, 1)] float shootSoundVolume = 0.1f;


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

    private void OnTriggerEnter2D(Collider2D other)
    {
        DamagedDealer damagedDealer = other.gameObject.GetComponent<DamagedDealer>();
        ProcessHit(damagedDealer);
    }

    private void ProcessHit(DamagedDealer damagedDealer)
    {
       playerHealth -= damagedDealer.TheDamagedBullets();

        if( playerHealth <=0)
        {
            Destroy(gameObject);
        }
    }
    private void Die()
    {
        Destroy(gameObject);
        AudioSource.PlayClipAtPoint(playerDeathSound, Camera.main.transform.position, playerDeathSoundVolume);
    }

}


