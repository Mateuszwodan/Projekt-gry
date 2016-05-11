using UnityEngine;
using System.Collections;
using System;

public class camera : MonoBehaviour {

    public Transform pojazd;

    int[] x_position = new int[] { 0, -20, 0, 20 };
    int[] z_position = new int[] { -20, 0, 20, 0 };
    int position = 0; // From 0 to 3 (N,S,W,E)

    void Update()
    {
        set_camera();
        change_camera();
    }

    private void change_camera()
    {        
        Vector3 static_pov = new Vector3(x_position[position], 40f, z_position[position]);
        Vector3 new_position = static_pov + pojazd.transform.position;
        transform.position = Vector3.Lerp(transform.position, new_position, Time.deltaTime * 2f);
    }

    private void set_camera()
    {
        float rotation = 0f;

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rotation = rotation + 90f;
            position = (position + 1) % 4;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rotation = rotation - 90f;
            position = (position - 1);
            if (position == -1)
                position = 3;
        }

        transform.Rotate(0f, rotation, 0f, Space.World);
    }
}


