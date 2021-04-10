using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenCoin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ModeCoin.currentCoin += 5;
        gameObject.SetActive(false);
    }
}
