using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockObject : MonoBehaviour
{
    public int car2Owning;
    public GameObject buyCar2;
    public GameObject car2;

    public int car3Owning;
    public GameObject buyCar3;
    public GameObject car3;

    // Start is called before the first frame update
    void Start()
    {
        car2Owning = PlayerPrefs.GetInt("Car2Owning");
        if (car2Owning == 2)
        {
            buyCar2.SetActive(false);
            car2.SetActive(true);
        }

        car3Owning = PlayerPrefs.GetInt("Car3Owning");
        if(car3Owning == 3)
        {
            buyCar3.SetActive(false);
            car3.SetActive(true);
        }
    }
}
