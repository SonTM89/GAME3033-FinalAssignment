using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GlobalCoin : MonoBehaviour
{
    public int CoinValue;
    public static int TotalCoin;

    public TextMeshProUGUI CoinText;

    // Start is called before the first frame update
    void Start()
    {
        TotalCoin = PlayerPrefs.GetInt("SavedCoin");
    }

    // Update is called once per frame
    void Update()
    {
        CoinValue = TotalCoin;
        CoinText.text = "Coins: " + CoinValue.ToString();
    }
}
