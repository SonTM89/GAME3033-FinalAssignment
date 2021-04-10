using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowCoin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ModeCoin.currentCoin += 15;
        gameObject.SetActive(false);
    }
}
