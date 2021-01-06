using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagedDealer : MonoBehaviour
{
    [SerializeField] int damagedBullets = 3; //the amount of damages in the script 

    public int TheDamagedBullets()
    {
        return damagedBullets; //to use the variable 
    }
    //To destroy 
    public void HitObject()
    {
        Destroy(gameObject);

    }
}