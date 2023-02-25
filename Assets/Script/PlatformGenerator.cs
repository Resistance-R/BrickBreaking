using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public GameObject platformPrefab; // 생성할 플랫폼 프리팹
    public int numPlatforms; // 생성할 플랫폼 수
    public float spacing; // 플랫폼 간 간격

    void Start()
    {
        //PlatformSpawn();
    }


    void Update()
    {
        
    }
    // private void PlatformSpawn()
    // {
    //     GameObject platform = Instantiate(platformPrefab); // 플랫폼 생성
    //     platform.GetComponent<aboutPlatform>().SpawnSpot(); // 플랫폼 위치 설정
    // }
}
