using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Sprite[] lives;
    public Image livesImageDisplay;
    public GameObject titleScreen;
    public GameObject playButton;
    public GameObject instructionButton;
    public GameObject instructionPanel;
    public GameObject instructionPanelCancel;
    public GameObject scoreTextMesh;
    //public GameObject shoot;

    public Text scoreText; 
    public int score;

    
    public void UpdateLives(int currentlives)
    {
        livesImageDisplay.sprite = lives[currentlives]; 
    }
    public void UpdateScore()
    {
        score += 10;
        scoreText.text = "Score: " + score;
    }
    public void ShowTitleScreen()
    {
        scoreTextMesh.SetActive(false);
        titleScreen.SetActive(true);
        playButton.SetActive(true);
        instructionButton.SetActive(true);
        instructionPanel.SetActive(false);
    }

    public void HideTitleScreen()
    {
        scoreTextMesh.SetActive(true);
        titleScreen.SetActive(false);
        playButton.SetActive(false);
        instructionButton.SetActive(false);
        instructionPanel.SetActive(false);
        scoreText.text = "Score: ";
    }

    public void OnClickInstructions()
    {
        //main menu close
        titleScreen.SetActive(false);
        playButton.SetActive(false);
        instructionButton.SetActive(false);
        instructionPanel.SetActive(true);
    }
    public void OnClickCancelInstructions()
    {
        titleScreen.SetActive(true);
        playButton.SetActive(true);
        instructionButton.SetActive(true);
        instructionPanel.SetActive(false);

    }
}
