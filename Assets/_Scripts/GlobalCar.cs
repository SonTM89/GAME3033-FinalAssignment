using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalCar : MonoBehaviour
{
    public static int CarType;
    public GameObject ModeSelection;

    public void Car1()
    {
        CarType = 1;
        ModeSelection.SetActive(true);
    }

    public void Car2()
    {
        CarType = 2;
        ModeSelection.SetActive(true);
    }

    public void Car3()
    {
        CarType = 3;
        ModeSelection.SetActive(true);
    }
}
