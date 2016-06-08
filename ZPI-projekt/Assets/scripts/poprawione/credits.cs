using UnityEngine;
using System.Collections;

public class credits : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Time.timeScale = 1;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.LoadLevel(0);
        }
        transform.Translate(Vector3.up * Time.deltaTime);
    }
}
