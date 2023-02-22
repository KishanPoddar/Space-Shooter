using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool gameOver = true;
    public bool gamePaused = false;
    public GameObject player;
    public GameObject startGame;
    private UIManager _uiManager;

    private void Start()
    {
        player.gameObject.SetActive(false);
        _uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
        Time.timeScale = 0;
        startGame.SetActive(true);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (gamePaused && Input.GetKeyDown(KeyCode.P))
        {
            gamePaused = false;
            Time.timeScale = 1;
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            gamePaused = true;
            Time.timeScale = 0;
        }

    }

    public void OnClickPlay()
    {
        startGame.SetActive(false);
        Time.timeScale = 1;
        player.gameObject.SetActive(true);
        gameOver = false;
        _uiManager.HideTitleScreen();
    }
}