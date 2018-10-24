using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    Rigidbody2D rb;

    public float upForce;
    bool started;
    bool gameOver;
    public float rotation;

    // Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        started = false;
        gameOver = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (!started)
        {
            if (Input.GetMouseButtonDown(0))
            {
                started = true;
                rb.isKinematic = false;
                GameManager.instance.GameStart();
            }
        }
        else if(started && !gameOver) 
        {
            transform.Rotate(0, 0, rotation);

            if (Input.GetMouseButtonDown(0))
            {
                rb.velocity = Vector2.zero;
                rb.AddForce(new Vector2(0, upForce));
            }
        }
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        gameOver = true;
        GameManager.instance.GameOver();
        GetComponent<Animator>().Play("Ball");

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Pipe" && !gameOver)
        {
            gameOver = true;
            GameManager.instance.GameOver();

            GetComponent<Animator>().Play("Ball");
        }
        if (col.gameObject.tag == "ScoreChecker" && !gameOver)
        {
            ScoreManager.instance.IncrementScore();
        }
    }
}
