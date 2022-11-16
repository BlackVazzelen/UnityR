using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform PlayerTransform;
    public Vector3 offset;

    void FixedUpdate()
    {
        transform.position = new Vector3(PlayerTransform.position.x + offset.x, PlayerTransform.position.y + offset.y, PlayerTransform.position.z + offset.z);
    }
}
