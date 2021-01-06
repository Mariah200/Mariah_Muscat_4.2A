using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsatcleSpawn : MonoBehaviour
{
    //to spawn obsatcles (to shoot)
    [SerializeField] List<ThewaveConfig> ThewaveConfigList;
    [SerializeField] bool loop = false;

    int TowaveStart = 0;

    IEnumerator Start()
    {
        do
        {
            yield return StartCoroutine(ToShotTheWaves());
        }
        while (loop == true);
    }
    private IEnumerator ToShotAllTheWaves(ThewaveConfig waveConfig)
    {
        for (int TheobstacleCount = 1; TheobstacleCount <= waveConfig.GettingNum(); TheobstacleCount++)
        {
            var obstacle = Instantiate(waveConfig.GetObstacle(), waveConfig.ThePoints()[0].transform.position, Quaternion.identity);

            obstacle.GetComponent<ObstaclePath>().ToSetTheConfig(waveConfig);
            yield return new WaitForSeconds(waveConfig.GetTime());
        }
    }

    private IEnumerator ToShotTheWaves()
    {
        foreach (ThewaveConfig currentWave in ThewaveConfigList)
        {
            yield return StartCoroutine(ToShotAllTheWaves(currentWave));

        }
    }

}