using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrackSelectMenu : MonoBehaviour
{
    public void OnMainMenuButtonPressed()
    {
        SceneManager.LoadScene(0);
    }


    public void Track01Selected()
    {
        //SceneManager.LoadScene("Gameplay");
        SceneManager.LoadScene(2);
    }


    //public void Track02Selected()
    //{
    //    //SceneManager.LoadScene("Gameplay");
    //    SceneManager.LoadScene(2);
    //}
}
