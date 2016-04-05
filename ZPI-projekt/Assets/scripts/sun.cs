using UnityEngine;
using System.Collections;

public class sun : MonoBehaviour
{

    public float speed = 0.0001F;

    void Start()
    {

    }

    void Update()
    {

        float rotationSpeed = Time.deltaTime / 0.2f;
        transform.Rotate(0f, rotationSpeed, 0f, Space.World);

    }
}
