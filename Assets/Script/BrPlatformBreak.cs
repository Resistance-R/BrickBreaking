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
            Destroy(this.gameObject);
        }

    }

    private void OnCollisionExit2D(Collision2D other) 
    {
        if(other.collider.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}