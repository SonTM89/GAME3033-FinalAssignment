using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockObject : MonoBehaviour
{
    public int greenSelect;
    public GameObject fakeGreen;

    // Start is called before the first frame update
    void Start()
    {
        greenSelect = PlayerPrefs.GetInt("GreenBought");
        if(greenSelect == 100)
        {
            fakeGreen.SetActive(false);
        }
    }
}
