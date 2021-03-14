using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LapTimeManager : MonoBehaviour
{
    public static int minute;
    public static int second;
    public static float milisecond;
    public static string miliDisplay;

    public TextMeshProUGUI MinuteText;
    public TextMeshProUGUI SecondText;
    public TextMeshProUGUI MiliText;

    // Update is called once per frame
    void Update()
    {
        milisecond += Time.deltaTime * 10;

        if(milisecond >= 10)
        {
            milisecond = 0;
            second += 1;
        }

        miliDisplay = milisecond.ToString("F0");
        MiliText.text = "." + miliDisplay;

        if (second <= 9)
        {
            SecondText.text = "0" + second.ToString();
        }
        else
        {
            SecondText.text = second.ToString();
        }

        if(second >= 60)
        {
            second = 0;
            minute += 1;
        }

        if (minute <= 9)
        {
            MinuteText.text = "0" + minute.ToString() + ":";
        }
        else
        {
            MinuteText.text = minute.ToString() + ":";
        }
    }
}
