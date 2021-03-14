using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Countdown : MonoBehaviour
{
    public GameObject CountDownBox;
    public TextMeshProUGUI CountDown;
    public AudioSource GetReady;
    public AudioSource GoAudio;
    public GameObject LapTimer;
    public GameObject CarControls;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountStart());
    }

    IEnumerator CountStart()
    {
        yield return new WaitForSeconds(0.5f);

        CountDown.text = "3";
        GetReady.Play();
        CountDownBox.SetActive(true);

        yield return new WaitForSeconds(1.0f);
        CountDownBox.SetActive(false);
        CountDown.text = "2";
        GetReady.Play();
        CountDownBox.SetActive(true);

        yield return new WaitForSeconds(1.0f);
        CountDownBox.SetActive(false);
        CountDown.text = "1";
        GetReady.Play();
        CountDownBox.SetActive(true);

        yield return new WaitForSeconds(1.0f);
        CountDownBox.SetActive(false);
        GoAudio.Play();
        LapTimer.SetActive(true);
        CarControls.SetActive(true);
    }
}
