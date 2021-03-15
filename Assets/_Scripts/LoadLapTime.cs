using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LoadLapTime : MonoBehaviour
{
    public int minute;
    public int second;
    public string milisecond;

    public TextMeshProUGUI minuteText;
    public TextMeshProUGUI secondText;
    public TextMeshProUGUI milisecondText;

    // Start is called before the first frame update
    void Start()
    {
        minute = PlayerPrefs.GetInt("Save_min");
        second = PlayerPrefs.GetInt("Save_sec");
        milisecond = PlayerPrefs.GetString("Save_mil");

        minuteText.text = minute.ToString() + ":";
        secondText.text = second.ToString();
        milisecondText.text = "." + milisecond;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
