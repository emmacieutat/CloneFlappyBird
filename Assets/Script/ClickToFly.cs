using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToFly : MonoBehaviour
{
    public GameManager gameManager;
    public Transform BirdRotation;
    public Rigidbody2D BirdPosition;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            BirdPosition.velocity = new Vector3(0, 3, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
    }

  
}
