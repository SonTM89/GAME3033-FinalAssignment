using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LapTotalSetting : MonoBehaviour
{
    private int lapTotal;
    public TextMeshProUGUI LapTotalText;

    // Start is called before the first frame update
    void Start()
    {
        lapTotal = ModeSelect.lapTotal;

        LapTotalText.text = "/ " + lapTotal;
    }

}
