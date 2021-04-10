using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Unlockable : MonoBehaviour
{
    public GameObject greenButton;
    public int CoinValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CoinValue = GlobalCoin.TotalCoin;

        if(CoinValue >= 100)
        {
            greenButton.GetComponent<Button>().interactable = true;
        }
    }

    public void GreenUnlock()
    {
        greenButton.SetActive(false);
        CoinValue -= 100;
        GlobalCoin.TotalCoin -= 100;
        PlayerPrefs.SetInt("SavedCoin", GlobalCoin.TotalCoin);
        PlayerPrefs.SetInt("GreenBought", 100);
    }
}
