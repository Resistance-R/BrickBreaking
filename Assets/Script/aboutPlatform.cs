using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//G14_182
//Smart14_182

public class aboutPlatform : MonoBehaviour
{
    [SerializeField]
    GameObject Platform, StPlatform, PlatformBr, StPlatformBr;

    void Start() 
    {
     InvokeRepeating("Spawn", 1f, 1f);   
    }

    void Update() 
    {
        
    }

    private void Spawn()
    {
        int xPos = Random.Range(-10, 11);
        float yPos = PlatformUp();
        int PlatformSpawner = Random.Range(1, 5);

        switch(PlatformSpawner)
        {
            case 1:
                Instantiate(Platform, new Vector2(xPos, yPos), Quaternion.identity);
                break;

            case 2:
                Instantiate(StPlatform, new Vector2(xPos, yPos), Quaternion.identity);
                break;

            case 3:
                Instantiate(PlatformBr, new Vector2(xPos, yPos), Quaternion.identity);
                break;

            case 4:
                Instantiate(StPlatformBr, new Vector2(xPos, yPos), Quaternion.identity);
                break;
        }
    }

    private float PlatformUp()
    {
        float PlayerFinder = GameObject.Find("Player").transform.position.y;
        float yPosSpace = Random.Range(0f, 2f);
        float PlatformSpace = PlayerFinder + yPosSpace;

        return(float) PlatformSpace;
    }

}