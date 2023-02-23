using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Sprite[] lives;
    public Image livesImageDisplay;
    public GameObject playButton;
    public GameObject playerLives;
    public GameObject instructionButton;
    public GameObject instructionPanel;
    public GameObject instructionPanelCancel;
    public GameObject scoreTextMesh;

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
        playerLives.SetActive(false);
        playButton.SetActive(true);
        instructionButton.SetActive(true);
        instructionPanel.SetActive(false);
    }

    public void HideTitleScreen()
    {
        scoreTextMesh.SetActive(true);
        playerLives .SetActive(true);
        playButton.SetActive(false);
        instructionButton.SetActive(false);
        instructionPanel.SetActive(false);
        scoreText.text = "Score: ";
    }

    public void OnClickInstructions()
    {
        playButton.SetActive(false);
        instructionButton.SetActive(false);
        instructionPanel.SetActive(true);
    }
    public void OnClickCancelInstructions()
    {
        playButton.SetActive(true);
        instructionButton.SetActive(true);
        instructionPanel.SetActive(false);

    }
}
