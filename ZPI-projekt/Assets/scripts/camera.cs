using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {

    public Transform pojazd;

    int[] a = new int[] { 0, -20, 0, 20 };
    int[] b = new int[] { -20, 0, 20, 0 };
    int xxx = 0;

    void Update()
    {
        float rotation = 0f;
        Vector3 stala = new Vector3(a[xxx], 60f, b[xxx]);
        Vector3 nowaPozycja = stala + pojazd.transform.position;
        transform.position = Vector3.Lerp(transform.position, nowaPozycja, Time.deltaTime * 2f);
        

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rotation = rotation + 90f;
            xxx = (xxx + 1) % 4;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rotation = rotation - 90f;
            xxx = (xxx - 1);
            if (xxx == -1)
                xxx = 3;
        }

        transform.Rotate(0f, rotation, 0f, Space.World);
    }
}


