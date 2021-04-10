using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LapComplete : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    public TextMeshProUGUI MinuteText;
    public TextMeshProUGUI SecondText;
    public TextMeshProUGUI MiliText;

    public TextMeshProUGUI LapCounterText;
    public int lapDone;
    public int lapTotal;

    public float rawTime;

    public GameObject RaceFinish;


    private void Start()
    {
        lapTotal = ModeSelect.lapTotal;
    }

    private void Update()
    {
        if(lapDone == lapTotal)
        {
            RaceFinish.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && lapDone < lapTotal)
        {
            lapDone++;

            if (PlayerPrefs.HasKey("RawTime"))
            {
                rawTime = PlayerPrefs.GetFloat("RawTime");
                if (LapTimeManager.rawTime <= rawTime)
                {
                    if (LapTimeManager.second <= 9)
                    {
                        SecondText.text = "0" + LapTimeManager.second.ToString();
                    }
                    else
                    {
                        SecondText.text = LapTimeManager.second.ToString();
                    }

                    if (LapTimeManager.minute <= 9)
                    {
                        MinuteText.text = "0" + LapTimeManager.minute.ToString() + ":";
                    }
                    else
                    {
                        MinuteText.text = LapTimeManager.minute.ToString() + ":";
                    }

                    MiliText.text = "." + LapTimeManager.miliDisplay;

                    PlayerPrefs.SetInt("Save_min", LapTimeManager.minute);
                    PlayerPrefs.SetInt("Save_sec", LapTimeManager.second);
                    PlayerPrefs.SetString("Save_mil", LapTimeManager.miliDisplay);
                    PlayerPrefs.SetFloat("RawTime", LapTimeManager.rawTime);
                }
            }
            else
            {
                if (LapTimeManager.second <= 9)
                {
                    SecondText.text = "0" + LapTimeManager.second.ToString();
                }
                else
                {
                    SecondText.text = LapTimeManager.second.ToString();
                }

                if (LapTimeManager.minute <= 9)
                {
                    MinuteText.text = "0" + LapTimeManager.minute.ToString() + ":";
                }
                else
                {
                    MinuteText.text = LapTimeManager.minute.ToString() + ":";
                }

                MiliText.text = "." + LapTimeManager.miliDisplay;

                PlayerPrefs.SetInt("Save_min", LapTimeManager.minute);
                PlayerPrefs.SetInt("Save_sec", LapTimeManager.second);
                PlayerPrefs.SetString("Save_mil", LapTimeManager.miliDisplay);
                PlayerPrefs.SetFloat("RawTime", LapTimeManager.rawTime);
            }




            LapTimeManager.lastMinute = LapTimeManager.minute;
            LapTimeManager.lastSecond = LapTimeManager.second;
            LapTimeManager.lastMiliDisplay = LapTimeManager.miliDisplay;


            LapTimeManager.minute = 0;
            LapTimeManager.second = 0;
            LapTimeManager.milisecond = 0;
            LapTimeManager.rawTime = 0;

            LapCounterText.text = lapDone.ToString();

            if(lapDone < lapTotal)
            {
                HalfLapTrig.SetActive(true);
                LapCompleteTrig.SetActive(false);
            } 
        }

        
    }
}
