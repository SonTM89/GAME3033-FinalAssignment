using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenScore : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ModeScore.currentScore += 50;
        gameObject.SetActive(false);
    }
}
