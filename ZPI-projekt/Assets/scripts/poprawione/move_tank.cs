using UnityEngine;
using System.Collections;
using System;

public class move_tank : MonoBehaviour {

    public GameObject left;
    public GameObject right;
    public GameObject player;
    public GameObject bullet;
    public GameObject cannon;

    private float leftPointx;
    private float rightPointx;
    private float leftPointz;
    private float rightPointz;

    private Vector3 rotationDirection;
    private float factorSpeed;

    public float range_of_enemy = 5;
    public bool toRight = false;
    public bool toDown = false;
    public bool stop = false;
    public float maxSpeed = 2;

    private Rigidbody myRigidbody;
    private Transform myTransform;
    private bool shooting=false;

    void Start () {
        myRigidbody = this.GetComponent<Rigidbody>();
        myTransform = this.GetComponent<Transform>();
        leftPointx = left.transform.position.x;
        rightPointx = right.transform.position.x;
        leftPointz = left.transform.position.z;
        rightPointz = right.transform.position.z;
        factorSpeed = (rightPointx - leftPointx) / (rightPointz - leftPointz);
    }


    void FixedUpdate()
    {
        if (ifShoot())
        {
            rotateToPlayer();
            if (!shooting)
            {
                StartCoroutine(shoot());
            }
        }
        else if (!stop)
        {
            move();
        }
    }

    private void rotateToPlayer()
    {
        myRigidbody.velocity = new Vector3(0, myRigidbody.velocity.y, 0);

        rotationDirection = (player.transform.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(rotationDirection);
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * maxSpeed);
    }

    private void move()
    {
        float px = myTransform.position.x;
        float pz = myTransform.position.z;

        float horizontal = 0;
        float vertical = 0;


        if (!toRight)
        {
            horizontal = (int)(leftPointx - px);
        }
        else
        {
            horizontal = (int)(rightPointx - px);
        }
        if (horizontal == 0)
        {
            toRight = !toRight;
        }



        if (!toDown)
        {
            vertical = (int)(leftPointz - pz);
        }
        else
        {
            vertical = (int)(rightPointz - pz);
        }
        if (vertical == 0)
        {
            toDown = !toDown;
        }



        int rightleft;
        int downup;

        if (toRight)
        {
            rightleft = 1;
        }
        else
        {
            rightleft = -1;
        }

        if (toDown)
        {
            downup = 1;
        }
        else
        {
            downup = -1;
        }

        myRigidbody.velocity = new Vector3(maxSpeed * rightleft * factorSpeed, myRigidbody.velocity.y, maxSpeed * downup);

        if (toRight)
        {
            rotationDirection = (right.transform.position - transform.position).normalized;
        }
        else
        {
            rotationDirection = (left.transform.position - transform.position).normalized;
        }

        Quaternion lookRotation = Quaternion.LookRotation(rotationDirection);
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * maxSpeed);
    }

    private IEnumerator shoot()
    {


    GameObject kula = GameObject.Instantiate(bullet);
    kula.transform.position = cannon.GetComponent<Transform>().position;
    kula.transform.rotation = cannon.GetComponent<Transform>().rotation;



    shooting = true;
    yield return new WaitForSeconds(1f);
    shooting = false;
}

    private bool ifShoot()
    {
        if (Vector3.Distance(player.transform.position, transform.position) < range_of_enemy)
        {
            return true;
        }
        else
        {
            return false;
        }       
    }
}
