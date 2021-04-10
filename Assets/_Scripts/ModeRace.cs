using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeRace : MonoBehaviour
{
    public int ModeSelection;

    public static int collectedCoins;

    // Start is called before the first frame update
    void Start()
    {
        ModeSelection = ModeSelect.RaceMode;

        if (ModeSelection == 1)
        {
            collectedCoins = 0;
        }
    }

}
