using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    [SerializeField] float scrollingBackgroundspeed = 1.0f;

    Material TheBackgroundMaterial;

    Vector2 offSet; //The movement offset

    void Start()
    {
        TheBackgroundMaterial = GetComponent<Renderer>().material;

        offSet = new Vector2(0f, scrollingBackgroundspeed);
    }
        
    void Update()
        {
            TheBackgroundMaterial.mainTextureOffset += offSet * Time.deltaTime;
        }
    }
