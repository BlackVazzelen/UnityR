using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float Acceleration;
    public float maxSteeringAngle;
    public Wheel[] FrontWheels;
    public Wheel[] RearWheels;

    [Range(-1,1)]
    public float forward;
    [Range(-1, 1)]
    public float turn;

    void FixedUpdate()
    {
        foreach (var wheel in FrontWheels)
            wheel.collider.steerAngle = Mathf.Lerp(wheel.collider.steerAngle, turn * maxSteeringAngle, 0.5f);

        foreach (var Wheel in RearWheels)
            Wheel.collider.motorTorque = forward * Acceleration;
    }
}
