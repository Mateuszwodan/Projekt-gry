using UnityEngine;
using System.Collections;

public class credits : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.anyKey)
        {
            Application.LoadLevel(0);
        }
        transform.Translate(Vector3.up * Time.deltaTime);
    }
}
