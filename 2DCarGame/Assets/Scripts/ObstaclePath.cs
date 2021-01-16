using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclePath : MonoBehaviour
{
    [SerializeField] List<Transform> Thewavepoint;

    [SerializeField] ObstacleWaveConfig obstaclewave;

    int obstaclewaveElement = 0;

    void Start()
    {
        Thewavepoint = obstaclewave.ThePoints();

        transform.position = Thewavepoint[obstaclewaveElement].transform.position;
    }

    private void Update()
    {
        TheObstacleMove();
    }
    private void TheObstacleMove()
    {
        if (obstaclewaveElement <= Thewavepoint.Count - 1)
        {
            var positionTarget = Thewavepoint[obstaclewaveElement].transform.position;

            positionTarget.z = 0f;

            var obstacleMove = obstaclewave.MovementSpeed() * Time.deltaTime;

            transform.position = Vector2.MoveTowards(transform.position, positionTarget, obstacleMove);

            if (transform.position == positionTarget)
            {
                obstaclewaveElement++;
            }


        }

        else
        {
            Destroy(gameObject); //if object reaches the last point
        }
    }

    public void ToSetTheConfig(ObstacleWaveConfig obstaclewaveSet)
    {
        obstaclewave = obstaclewaveSet;
    }
}




