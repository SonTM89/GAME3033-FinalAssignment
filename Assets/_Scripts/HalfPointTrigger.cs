using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointTrigger : MonoBehaviour
{
    public GameObject LabCompleteTrigger;
    public GameObject HalfLapTrigger;

    private void OnTriggerEnter(Collider other)
    {
        LabCompleteTrigger.SetActive(true);
        HalfLapTrigger.SetActive(false);

    }
}
