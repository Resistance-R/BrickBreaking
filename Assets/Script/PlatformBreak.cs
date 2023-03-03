using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBreak : MonoBehaviour
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
            Destroy(this.gameObject);
            Debug.Log("impact!");
        }
    }
}