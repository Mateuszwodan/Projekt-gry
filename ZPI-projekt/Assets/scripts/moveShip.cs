using UnityEngine;
using System.Collections;
using System;

public class moveShip : MonoBehaviour {

    float veloc = 0.0f;

    void Update () {


        veloc = 0f;
        Rigidbody rigidbody = transform.GetComponent<Rigidbody>();
        Vector3 velocity = rigidbody.velocity;
        float direct = transform.rotation.y;
        float rotation = 0f;
        

        if (Input.GetKey(KeyCode.D))
        {
            rotation = rotation + 2f;
        }

        if (Input.GetKey(KeyCode.A))
        {
            rotation = rotation - 2f;
        }

        if (Input.GetKey(KeyCode.W))
        {
            veloc = veloc + 30f;
        }

        if (Input.GetKey(KeyCode.S))
        {
            veloc = veloc - 30f;
        }

        var localV = transform.InverseTransformDirection(rigidbody.velocity);
        localV.x = veloc;
        localV.y = 0.0f;
        var worldV = transform.TransformDirection(localV);
        worldV.y = -10f;
        rigidbody.velocity = worldV;

        transform.Rotate(0f, rotation, 0f, Space.World);
        
    }

   

    }
