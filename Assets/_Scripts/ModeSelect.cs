using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeSelect : MonoBehaviour
{
    public static int RaceMode; // Race = 0, Score = 1, Time = 2
    public static int lapTotal; // Race = 3, Score = Time = 1
    public GameObject TrackSelect;

    public void RacingMode()
    {
        RaceMode = 0;
        lapTotal = 1;
        TrackSelect.SetActive(true);
    }

    public void CoinMode()
    {
        RaceMode = 1;
        lapTotal = 1;
        TrackSelect.SetActive(true);
    }

    public void TimeMode()
    {
        RaceMode = 2;
        lapTotal = 1;
        TrackSelect.SetActive(true);
    }
}
