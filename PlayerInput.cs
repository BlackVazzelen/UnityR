using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    public CarMovement CarMovement { get; private set; }

    void Awake()
    {
        CarMovement = GetComponent<CarMovement>();
    }
        
    void Update()
    {
        CarMovement.forward = Input.GetAxis("Vertical");
        CarMovement.turn = Input.GetAxis("Horizontal");
    }
}
