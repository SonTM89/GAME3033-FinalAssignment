using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ModeCoin : MonoBehaviour
{
    public int ModeSelection;

    public GameObject CoinObjects;
    public GameObject RaceUI;
    public GameObject CoinUI;
    public GameObject AICar;
    public static int currentCoin;
    public int InternalCoin;

    public TextMeshProUGUI CoinText;

    // Start is called before the first frame update
    void Start()
    {
        ModeSelection = ModeSelect.RaceMode;

        if (ModeSelection == 1)
        {
            currentCoin = 0;

            RaceUI.SetActive(false);
            CoinUI.SetActive(true);
            AICar.SetActive(false);
            CoinObjects.SetActive(true);
        }
    }


    private void Update()
    {
        InternalCoin = currentCoin;
        CoinText.text = InternalCoin.ToString();
    }
}
