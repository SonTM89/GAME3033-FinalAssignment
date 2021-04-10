using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCoin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ModeCoin.currentCoin += 10;
        gameObject.SetActive(false);
    }
}
