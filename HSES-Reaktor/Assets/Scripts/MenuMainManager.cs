﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuMainManager : MonoBehaviour
{
    public const string sceneName = "MenuMain";

    public Button ButtonPlayerCnt1;
    public Button ButtonPlayerCnt2;
    public Button ButtonPlayerCnt3;
    public Button ButtonPlayerCnt4;

    void Start()
    {

        ButtonPlayerCnt1 = ButtonPlayerCnt1.GetComponent<Button>();
        ButtonPlayerCnt2 = ButtonPlayerCnt2.GetComponent<Button>();
        ButtonPlayerCnt3 = ButtonPlayerCnt3.GetComponent<Button>();
        ButtonPlayerCnt4 = ButtonPlayerCnt4.GetComponent<Button>();
    }

    public void HandlePlayersCountClick(Button buttonClicked)
    {
        Debug.Log("Players count button clicked.");

        if (buttonClicked == ButtonPlayerCnt1)
        {
            GameManager.PlayersCount = 1;
        }
        else if (buttonClicked == ButtonPlayerCnt2)
        {
            GameManager.PlayersCount = 2;
        }
        else if (buttonClicked == ButtonPlayerCnt3)
        {
            GameManager.PlayersCount = 3;
        }
        else if (buttonClicked == ButtonPlayerCnt4)
        {
            GameManager.PlayersCount = 4;
        }
    }

    public void HandleStartGameClick()
    {
        GameManager.StartGame();
    }

    public void HandleConfigGameClick()
    {
        SceneManager.LoadScene("MenuConfig");
    }
}
