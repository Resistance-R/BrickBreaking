using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrPlatformBreak : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.tag == "Lava")
        {
            GameObject[] destroyPlatform = GameObject.FindGameObjectsWithTag("Land");
            foreach (GameObject broken in destroyPlatform)
                Destroy(broken);
            Debug.Log("impact!");
        }
    }
}