using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aboutPlatform : MonoBehaviour
{
    public enum Type {Platform, StPlatform, PlatformBr, StPlatformBr};
    public Type platformType;

    void Start()
    {
        SpawnSpot();
    }

    void Update()
    {

    }

    private void SpawnSpot()
    {
        int childCount = transform.childCount;
        if (childCount == 0)
        {
            Debug.LogError("There are no child objects!");
            return;
        }

        int randomIndex = Random.Range(0, childCount);
        Transform randomChild = transform.GetChild(randomIndex);

        float xPos = randomChild.position.x;
        float yPos = randomChild.position.y;
        float zPos = 0f;

        GameObject platformPrefab = Resources.Load<GameObject>("Prefabs/" + platformType.ToString());
        GameObject newPlatform = Instantiate(platformPrefab, new Vector3(xPos, yPos, zPos), Quaternion.identity);
        newPlatform.transform.parent = randomChild;
    }
}