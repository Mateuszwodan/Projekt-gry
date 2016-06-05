using UnityEngine;
using System.Collections;

public class intro : MonoBehaviour {

    double czas = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.anyKey)
        {
            Application.LoadLevel(0);
        }
        czas = czas + Time.deltaTime;
        if(czas > 7)
        {
            Application.LoadLevel(0);
        }
    }
}
