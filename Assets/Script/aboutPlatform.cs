using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aboutPlatform : MonoBehaviour
{
    [SerializeField]
    GameObject Platform, StPlatform, PlatformBr, StPlatformBr;

    private float timer = 0;
    private int SpawnPlatform;
    private int currentPlatformCount = 0;
    private int maxPlatformCount = 10;
    private Rigidbody2D RG;

    void Start()
    {
        RG = GetComponent<Rigidbody2D>();
        Spawn();
    }

    void Update()
    {

    }

    public void Spawn()
    {
        GameObject gameObj = GameObject.Find("Lava");
        LavaController script = gameObj.GetComponent<LavaController>();
        InvokeRepeating("Spawn", 1f, 0.5f);

        if (script.gameOver == false && currentPlatformCount < maxPlatformCount)
        {

        float xPos = Random.Range(-10f, 10f);
        float yPos = 0f;
        float zPos = 0f;

        yPos = PlatformUp();
        SpawnPlatform = Random.Range(1,4);
        
        switch (SpawnPlatform)
        {
            case 1:
                Instantiate(Platform, gameObject.transform.position = new Vector3(xPos, yPos, zPos), Quaternion.identity);
                break;
            
            case 2:
                Instantiate(StPlatform, gameObject.transform.position = new Vector3(xPos, yPos, zPos), Quaternion.identity);
                break;

            case 3:
                Instantiate(PlatformBr, gameObject.transform.position = new Vector3(xPos, yPos, zPos), Quaternion.identity);
                break;

            case 4:
                Instantiate(StPlatformBr, gameObject.transform.position = new Vector3(xPos, yPos, zPos), Quaternion.identity);
                break;
        }
        currentPlatformCount++;
        }
    }

    private int PlatformUp()
    {
        int yPosSpace = Random.Range(1,2);

        timer += Time.deltaTime;
        float PlatformSpace = timer * 1.5f + yPosSpace;
        return (int) PlatformSpace;
    }
}