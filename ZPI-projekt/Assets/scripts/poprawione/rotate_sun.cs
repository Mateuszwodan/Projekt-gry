using UnityEngine;
using System.Collections;
using System;

public class rotate_sun : MonoBehaviour
{

    public float speed = 1.0F; // Normal: 1.0f

    void Update()
    {
        rotate_around_sun();  
    }

    private void rotate_around_sun()
    {
        float rotationSpeed = Time.deltaTime * speed;
        transform.Rotate(0f, rotationSpeed, 0f, Space.World);
    }
}
