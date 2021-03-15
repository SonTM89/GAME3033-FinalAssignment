using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public GameObject NormalCam;
    public GameObject FarCam;
    public GameObject FPCam;

    public int camMode;

    public InputMaster camAction;

    private void Awake()
    {
        camAction = new InputMaster();
    }

    private void OnEnable()
    {
        camAction.Enable();
    }

    private void OnDisable()
    {
        camAction.Disable();
    }

    private void Start()
    {
        camAction.Player.Viewmode.performed += _ => CamChanging();
    }

    void CamChanging()
    {
        if(camMode == 2)
        {
            camMode = 0;
        }
        else
        {
            camMode++;
        }

        StartCoroutine(ModeChange());
    }

    IEnumerator ModeChange()
    {
        yield return new WaitForSeconds(0.01f);
        if(camMode == 0)
        {
            NormalCam.SetActive(true);
            FPCam.SetActive(false);
        }
        else if(camMode == 1)
        {
            FarCam.SetActive(true);
            NormalCam.SetActive(false);
        }
        else if (camMode == 2)
        {
            FPCam.SetActive(true);
            FarCam.SetActive(false);
        }
    }
}
