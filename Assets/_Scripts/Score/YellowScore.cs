using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowScore : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ModeScore.currentScore += 80;
        gameObject.SetActive(false);
    }
}
