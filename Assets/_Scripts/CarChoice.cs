using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoice : MonoBehaviour
{
    public GameObject Body01;
    public GameObject Body02;
    public GameObject Body03;

    public int CarImport;

    // Start is called before the first frame update
    void Start()
    {
        CarImport = GlobalCar.CarType;

        if(CarImport == 1)
        {
            Body01.SetActive(true);
        }

        else if(CarImport == 2)
        {
            Body02.SetActive(true);
        }

        else if (CarImport == 3)
        {
            Body03.SetActive(true);
        }
    }
}
