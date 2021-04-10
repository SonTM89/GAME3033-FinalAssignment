using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ModeScore : MonoBehaviour
{
    public int ModeSelection;

    public GameObject ScoreObjects;
    public GameObject RaceUI;
    public GameObject ScoreUI;
    public GameObject AICar;
    public static int currentScore;
    public int InternalScore;

    public TextMeshProUGUI ScoreText;

    // Start is called before the first frame update
    void Start()
    {
        ModeSelection = ModeSelect.RaceMode;

        if(ModeSelection == 1)
        {
            RaceUI.SetActive(false);
            ScoreUI.SetActive(true);
            AICar.SetActive(false);
            ScoreObjects.SetActive(true);
        }
    }


    private void Update()
    {
        InternalScore = currentScore;
        ScoreText.text = InternalScore.ToString();
    }
}
