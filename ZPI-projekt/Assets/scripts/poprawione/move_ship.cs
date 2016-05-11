using UnityEngine;
using System.Collections;
using System;

public class move_ship : MonoBehaviour {

    float velocity = 0.0f;
    float rotation_speed = 2.0f;
    float move_speed = 30.0f;
    float to_ground_speed = -10.0f;

    void Update ()
    {
        rotation_of_ship();
        move_of_ship();           
    }

    private void move_of_ship()
    {
        this.velocity = 0f;
        Rigidbody rigidbody = transform.GetComponent<Rigidbody>();
        Vector3 velocity = rigidbody.velocity;
        float direct = transform.rotation.y;


        if (Input.GetKey(KeyCode.W))
        {
            this.velocity = this.velocity + move_speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            this.velocity = this.velocity - move_speed;
        }

        var local_vector = transform.InverseTransformDirection(rigidbody.velocity);
        local_vector.x = this.velocity;
        local_vector.y = 0.0f;

        var world_vector = transform.TransformDirection(local_vector);
        world_vector.y = to_ground_speed;
        rigidbody.velocity = world_vector;
    }

    private void rotation_of_ship()
    {
        float rotation = 0f;

        if (Input.GetKey(KeyCode.D))
        {
            rotation = rotation + rotation_speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            rotation = rotation - rotation_speed;
        }

        transform.Rotate(0f, rotation, 0f, Space.World);
    }
}
