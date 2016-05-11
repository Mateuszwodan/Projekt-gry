using UnityEngine;
using System.Collections;

public class ray : MonoBehaviour {

    bool direction = true;
    public int scope = 100;
    public Renderer rer;
    public BoxCollider col;
    int counter = 0;

	void Update () {
        if (direction)
        {
            if (counter < scope)
            {
                rer.enabled = true;
                col.enabled = true;
                counter++;
            }
            else
            {
                counter = 0;
                direction = !direction;
            }
        }
        else
        {
            if (counter < scope)
            {
                rer.enabled = false;
                col.enabled = false;
                counter++;
            }
            else
            {
                counter = 0;
                direction = !direction;
            }
        }
    }
}
