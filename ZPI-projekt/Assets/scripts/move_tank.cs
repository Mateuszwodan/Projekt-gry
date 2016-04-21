using UnityEngine;
using System.Collections;

public class move_tank : MonoBehaviour {

    public float leftPoint;
    public float rightPoint;
    public bool toRight = false;
    public bool stop = false;
    public bool xy = true;
    public float maxSpeed = 10;

    private Rigidbody myRigidbody;
    private Transform myTransform;

    void Start () {
        myRigidbody = this.GetComponent<Rigidbody>();
        myTransform = this.GetComponent<Transform>();
    }


    void FixedUpdate()
    {
        float pxy;
        if (xy)
        {
            pxy = myTransform.position.x;
        }
        else
        {
            pxy = myTransform.position.y;
        }
        float horizontal = 0;
        if (!toRight)
        {
            horizontal = (int)(leftPoint - pxy);
        }
        else
        {
            horizontal = (int)(rightPoint - pxy);
        }

        if (horizontal == 0)
        {
            toRight = !toRight;
        }


        int direction;

        if (toRight)
        {
            direction = 1;
        }
        else
        {
            direction = -1;
        }

        if (xy)
        {
            myRigidbody.velocity = new Vector3(maxSpeed * direction, myRigidbody.velocity.y);
        }
        else
        {
            myRigidbody.velocity = new Vector3(0, maxSpeed * direction);
        }
        
    }
}
