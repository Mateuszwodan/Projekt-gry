using UnityEngine;
using System.Collections;

public class enemy_health : MonoBehaviour {

    int health = 100;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "bullet")
        {
            health = health - 5;
            other.gameObject.SetActive(false);

        }
        if(health <= 0)
        {
            this.gameObject.SetActive(false);
        }
    }
}
