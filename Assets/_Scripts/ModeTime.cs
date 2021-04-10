using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ModeTime : MonoBehaviour
{
    public int ModeSelection;

    public GameObject AICar;

    public static bool isTimeMode = false;

    // Start is called before the first frame update
    void Start()
    {
        ModeSelection = ModeSelect.RaceMode;

        if (ModeSelection == 2)
        {
            isTimeMode = true;
            AICar.SetActive(false);
        }
    }


    private void Update()
    {

    }
}
