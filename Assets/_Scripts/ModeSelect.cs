using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeSelect : MonoBehaviour
{
    public static int RaceMode; // Race = 0, Score = 1, Time = 2
    public GameObject TrackSelect;

    public void RacingMode()
    {
        RaceMode = 0;
        TrackSelect.SetActive(true);
    }

    public void ScoreMode()
    {
        RaceMode = 1;
        TrackSelect.SetActive(true);
    }

    public void TimeMode()
    {
        RaceMode = 2;
        TrackSelect.SetActive(true);
    }
}
