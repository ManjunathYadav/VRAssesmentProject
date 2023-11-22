using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabableObjects : MonoBehaviour
{
    public Vector3 initialPosition;
    internal Quaternion initialRotation;

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
        initialRotation = transform.rotation;
    }
}
