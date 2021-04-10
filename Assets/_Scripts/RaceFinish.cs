using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class RaceFinish : MonoBehaviour
{
    public GameObject playerCar;
    public GameObject finishCam;
    public GameObject viewModes;
    public GameObject levelMusic;
    public GameObject completeTrig;
    public AudioSource finishMusic;

    private void OnTriggerEnter(Collider other)
    {
        if (ModeTime.isTimeMode == true)
        {

        }
        else
        {
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

            GlobalCoin.TotalCoin += 100;
            PlayerPrefs.SetInt("SavedCoin", GlobalCoin.TotalCoin);
        }  
    }
}
