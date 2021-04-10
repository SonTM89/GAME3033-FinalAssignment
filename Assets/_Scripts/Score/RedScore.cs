using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedScore : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ModeScore.currentScore += 100;
        gameObject.SetActive(false);
    }
}
