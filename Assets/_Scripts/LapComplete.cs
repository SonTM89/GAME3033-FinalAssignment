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

    private void OnTriggerEnter(Collider other)
    {
        if(LapTimeManager.second <= 9)
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

        LapTimeManager.minute = 0;
        LapTimeManager.second = 0;
        LapTimeManager.milisecond = 0;

        HalfLapTrig.SetActive(true);
        LapCompleteTrig.SetActive(false);
    }
}
