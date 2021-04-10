using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Unlockable : MonoBehaviour
{
    public GameObject BuyCar2;
    public GameObject Car2;
    public int car2Price = 100;

    public GameObject BuyCar3;
    public GameObject Car3;
    public int car3Price = 200;

    public int CoinValue;

    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.SetInt("SavedCoin", 200);
    }

    // Update is called once per frame
    void Update()
    {
        CoinValue = GlobalCoin.TotalCoin;

        if(CoinValue >= car2Price)
        {
            BuyCar2.GetComponent<Button>().interactable = true;
        }
        else
        {
            BuyCar2.GetComponent<Button>().interactable = false;
        }

        if (CoinValue >= car3Price)
        {
            BuyCar3.GetComponent<Button>().interactable = true;
        }
        else
        {
            BuyCar3.GetComponent<Button>().interactable = false;
        }
    }

    public void Car2Unlock()
    {
        BuyCar2.SetActive(false);
        Car2.SetActive(true);
        CoinValue -= car2Price;
        GlobalCoin.TotalCoin -= car2Price;
        PlayerPrefs.SetInt("SavedCoin", GlobalCoin.TotalCoin);
        PlayerPrefs.SetInt("Car2Owning", 2);
    }


    public void Car3Unlock()
    {
        BuyCar3.SetActive(false);
        Car3.SetActive(true);
        CoinValue -= car3Price;
        GlobalCoin.TotalCoin -= car3Price;
        PlayerPrefs.SetInt("SavedCoin", GlobalCoin.TotalCoin);
        PlayerPrefs.SetInt("Car3Owning", 3);
    }
}
