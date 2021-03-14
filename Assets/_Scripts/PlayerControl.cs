using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityStandardAssets.Vehicles.Car;
//using UnityStandardAssets.CrossPlatformInput;


[RequireComponent(typeof(CarController))]
public class PlayerControl : MonoBehaviour
{
    private InputMaster controls;

    private CarController m_Car; // the car controller we want to use

    private float h;
    private float v;
    private float handbrake;
 

    private void Awake()
    {
        // get the car controller
        m_Car = GetComponent<CarController>();

        controls = new InputMaster();

            
    }

    private void Start()
    {
        controls.Player.Brake.performed += ctx => Brake(ctx.ReadValue<float>());
        controls.Player.Movement.performed += ctx => Move(ctx.ReadValue<Vector2>());
    }


    void Brake(float brakeValue)
    {
        handbrake = brakeValue;
    }

    void Move(Vector2 direction)
    {
        h = direction.x;
        v = direction.y;
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }


    private void FixedUpdate()
    {
        // pass the input to the car!
        //float h = CrossPlatformInputManager.GetAxis("Horizontal");
        //float v = CrossPlatformInputManager.GetAxis("Vertical");

        //float handbrake = CrossPlatformInputManager.GetAxis("Jump");'    

        m_Car.Move(h, v, v, handbrake);
    }
}
