﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour 
{
    [SerializeField] float TheShot;

    [SerializeField] float minTimeofShots = 0.3f;//minimum times between the shots 

    [SerializeField] float mixTimeofShots = 4f; //maximum times between the shots 

    [SerializeField] GameObject TheFireObstacle;

    [SerializeField] float TheFireSpeedBullet = 0.3f;

    [SerializeField] float health = 100;

    [SerializeField] AudioClip ObstacleDeathSound;

    [SerializeField] [Range(0, 1)] float ObstacleSoundVolume = 0.75f;

    [SerializeField] int scoreValue = 100;





    private void OnTriggerEnter2D(Collider2D other)
    {
        DamagedDealer damagedDealer = other.gameObject.GetComponent<DamagedDealer>();
        health -= ProcessHit(damagedDealer);

        if (health <= 0)
        {
            Destroy(gameObject);
        }
        AudioSource.PlayClipAtPoint(ObstacleDeathSound, Camera.main.transform.position, ObstacleSoundVolume);

        FindObjectOfType<GameSession>().AddToScore(scoreValue);

    }


    private static int ProcessHit(DamagedDealer damagedDealer)
    {
        return damagedDealer.TheDamagedBullets();
    }

    private void Start()
    {
        TheShot = Random.Range(minTimeofShots, mixTimeofShots); //Generate Number between 0.3 and 4 
    }
    void Update()
    {
        TheShots();
    }
    private void TheShots()
    {
        TheShot -= Time.deltaTime;

        if (TheShot <= 0f)
        {
            TheFireAndBullets();
            TheShot = Random.Range(minTimeofShots, mixTimeofShots); //counting the shots
        }
    }

    private void TheFireAndBullets()
    {
        GameObject TheLaserBullets = Instantiate(TheFireObstacle, transform.position, Quaternion.identity) as GameObject;

        TheLaserBullets.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -TheFireSpeedBullet);

        AudioSource.PlayClipAtPoint(ObstacleDeathSound, Camera.main.transform.position, ObstacleSoundVolume);

    }

}
