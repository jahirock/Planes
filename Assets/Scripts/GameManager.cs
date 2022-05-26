using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public delegate void PlayerDeath();

    public static event PlayerDeath OnPlayerDeath;

    public GameObject gameOverScreen;

    public static GameManager sharedInstance;

    public static Action OnUpdateScore;

    private void OnEnable()
    {
        OnUpdateScore += UpdateScoreUI;
    }

    private void Awake()
    {
        gameOverScreen.SetActive(false);
        OnPlayerDeath += ShowGameOverScreen;
        if(sharedInstance == null)
        {
            sharedInstance = this;
        }
    }

    void ShowGameOverScreen()
    {
        gameOverScreen.SetActive(true);
    }


    public void PlayerKilled()
    {
        OnPlayerDeath?.Invoke();
    }

    public void UpdateScoreUI()
    {
        //Cambiar el valor del score en la UI
        Debug.Log("Score actualizado");
    }
}
