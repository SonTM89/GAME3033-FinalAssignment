using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Vehicles.Car;

public class RaceFinish : MonoBehaviour
{
    public GameObject playerCar;
    public GameObject finishCam;
    public GameObject viewModes;
    public GameObject levelMusic;
    public GameObject completeTrig;
    public AudioSource finishMusic;


    private void Update()
    {
        LapTimeManager.minute = 0;
        LapTimeManager.second = 0;
        LapTimeManager.milisecond = 0;
        LapTimeManager.rawTime = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (ModeSelect.RaceMode == 1)
        {
            GlobalCoin.TotalCoin += ModeCoin.currentCoin;
            PlayerPrefs.SetInt("SavedCoin", GlobalCoin.TotalCoin);
        }
        else if(ModeSelect.RaceMode == 0)
        {
            ModeRace.collectedCoins = 50;

            GlobalCoin.TotalCoin += ModeRace.collectedCoins;
            PlayerPrefs.SetInt("SavedCoin", GlobalCoin.TotalCoin);
        }

        this.GetComponent<BoxCollider>().enabled = false;
        playerCar.SetActive(false);
        completeTrig.SetActive(false);
        CarController.m_Topspeed = 0.0f;
        playerCar.GetComponent<CarController>().enabled = false;
        playerCar.GetComponent<PlayerControl>().enabled = false;

        playerCar.SetActive(true);
        finishCam.SetActive(true);
        levelMusic.SetActive(false);
        viewModes.SetActive(false);
        finishMusic.Play();

        StartCoroutine(GoToGameOver());
    }


    IEnumerator GoToGameOver()
    {
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene("GameOverScene");
    }
}

