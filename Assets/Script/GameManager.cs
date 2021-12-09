using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject GameOverCanvas;

    public GameObject text;

    private bool dead = false;

    private void Start()
    {
       Time.timeScale = 1;
    }
    
    public void GameOver()
    {
        GameOverCanvas.SetActive(true);
        Time.timeScale = 0;
        dead = true;
        text.transform.position = new Vector3(380, 815, 0);
    }

    public void Update()
    {
        if(Input.GetKeyDown("space") && dead == true)
        {
            SceneManager.LoadScene("GameScene");
            dead = false;
        }
    }


}
