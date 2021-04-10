using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverMenu : MonoBehaviour
{
    public GameObject Coins;
    public GameObject Time;

    public TextMeshProUGUI CoinsText;

    public TextMeshProUGUI MinuteText;
    public TextMeshProUGUI SecondText;
    public TextMeshProUGUI MiliText;


    private void Start()
    {
        if (ModeSelect.RaceMode == 0)
        {
            Coins.SetActive(true);
            CoinsText.text = "Collected Coins: " + ModeRace.collectedCoins.ToString();
        }
        else if (ModeSelect.RaceMode == 1)
        {
            Coins.SetActive(true);
            CoinsText.text = "Collected Coins: " + ModeCoin.currentCoin.ToString();
        }
        else if (ModeSelect.RaceMode == 2)
        {
            Time.SetActive(true);

            if (LapTimeManager.lastSecond <= 9)
            {
                SecondText.text = "0" + LapTimeManager.lastSecond.ToString();
            }
            else
            {
                SecondText.text = LapTimeManager.lastSecond.ToString();
            }

            if (LapTimeManager.lastMinute <= 9)
            {
                MinuteText.text = "0" + LapTimeManager.lastMinute.ToString() + ":";
            }
            else
            {
                MinuteText.text = LapTimeManager.lastMinute.ToString() + ":";
            }

            MiliText.text = "." + LapTimeManager.lastMiliDisplay;
        }
    }

    public void OnBackButtonPressed()
    {
        SceneManager.LoadScene(0);
    }


    public void OnQuitButtonPressed()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
