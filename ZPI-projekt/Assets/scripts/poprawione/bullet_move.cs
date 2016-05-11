using UnityEngine;
using System.Collections;

public class bullet_move : MonoBehaviour {

    private Rigidbody myRigidbody;

    void Start()
    {
        myRigidbody = this.GetComponent<Rigidbody>();
  
        myRigidbody.velocity = transform.forward * 100;
        Vector3 x = new Vector3(0, 0, 90);
    }

}

