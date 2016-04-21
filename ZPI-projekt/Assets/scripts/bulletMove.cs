using UnityEngine;
using System.Collections;

public class bulletMove : MonoBehaviour {

    private Transform myTransform;
    private Rigidbody myRigidbody;

    void Start()
    {
        myRigidbody = this.GetComponent<Rigidbody>();
        myTransform = this.GetComponent<Transform>();

        
        myRigidbody.velocity = transform.forward * 100;
      // Vector3 x = transform.forward;
        Vector3 x = new Vector3(0, 0, 90);
       // myRigidbody.AddForce(transform.forward * 100);
    }


    void Update()
    {
       
    }

}
