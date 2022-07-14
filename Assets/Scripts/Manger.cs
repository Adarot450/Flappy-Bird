using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manger : MonoBehaviour
{

    public GameObject GameOverCanvas;


    private void Start()
    {
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        GameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Replay()
    {
        SceneManager.LoadScene(0); 
    }

}
