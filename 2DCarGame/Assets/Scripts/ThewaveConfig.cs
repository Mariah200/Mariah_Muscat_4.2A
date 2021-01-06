using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThewaveConfig : MonoBehaviour
{
    [SerializeField] GameObject TheobstaclePrefab; //that will shot in this wave 

    [SerializeField] GameObject ThePathPrefab; //The path that the wave will follow 

    [SerializeField] GameObject ObstaclePrefab;

    [SerializeField] GameObject PathPrefab;

    [SerializeField] float TheMovOfObstacleSp = 3f;

    [SerializeField] int TheNumofObstacle = 5;

    [SerializeField] float TheTimeBetweenSpawns = 1.5f;

    [SerializeField] float TheSpawnRandFactor = 0.3f;

    public GameObject GetObstacle()
    {
        return TheobstaclePrefab;
    }

    public List<Transform> ThePoints()
    {
        var ThewavePoints = new List<Transform>();

        foreach (Transform child in PathPrefab.transform)
        {
            ThewavePoints.Add(child);
        }
        return ThewavePoints;
    }

    public float MovementSpeed()
    {
        return TheMovOfObstacleSp;
    }
    public int GettingNum()
    {
        return TheNumofObstacle;
    }
    public float GetTime()
    {
        return TheTimeBetweenSpawns;
    }



}


