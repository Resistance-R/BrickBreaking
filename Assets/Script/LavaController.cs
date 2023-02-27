using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaController : MonoBehaviour
{
    [SerializeField]
    private float lavaSpeed = 0.1f;

    private float timer = 0f;
    public bool gameOver = false;
    private Rigidbody2D RG;

    void Start()
    {
        RG = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        FillUp();
        GameOverDeclaration();
    }

    private void FillUp()
    {
        timer += Time.deltaTime;
        transform.position = new Vector2(0, transform.position.y + lavaSpeed * timer * 0.01f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            gameOver = true;
        }
    }

    private void GameOverDeclaration()
    {
        if (gameOver == true)
        {
            Time.timeScale = 0f;
            Debug.Log("Game Over");
        }
    }
}
