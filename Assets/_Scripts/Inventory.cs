using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Inventory : MonoBehaviour
{
    private int coinOwning;
    public TextMeshProUGUI coinOwningText;

    private int car2Owning;
    public GameObject Car2;

    private int car3Owning;
    public GameObject Car3;

    // Start is called before the first frame update
    void Start()
    {
        coinOwning = PlayerPrefs.GetInt("SavedCoin");
        coinOwningText.text = "Coins: " + coinOwning.ToString();

        car2Owning = PlayerPrefs.GetInt("Car2Owning");
        if (car2Owning == 2)
        {
            Car2.SetActive(true);
        }

        car3Owning = PlayerPrefs.GetInt("Car3Owning");
        if (car3Owning == 3)
        {
            Car3.SetActive(true);
        }
    }
}
