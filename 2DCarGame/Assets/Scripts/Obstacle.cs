using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] float TheShot;

    [SerializeField] float minTimeofShots = 0.3f;//minimum times between the shots 

    [SerializeField] float mixTimeofShots = 4f; //maximum times between the shots 

    [SerializeField] GameObject TheFireObstacle;

    [SerializeField] float TheFireSpeedBullet = 0.3f;

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
    }
}
