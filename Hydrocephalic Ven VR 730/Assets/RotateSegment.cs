using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSegment : MonoBehaviour
{
    public float rotationSpeed = 50;

    void Update()
    {
        float rotationPerFrame = rotationSpeed * Time.deltaTime;
        {
            transform.Rotate(0, 0, rotationPerFrame);
        }
    }
}