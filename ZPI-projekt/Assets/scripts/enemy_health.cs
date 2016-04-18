using UnityEngine;
using System.Collections;

public class enemy_health : MonoBehaviour {

    int health = 100;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (health <= 0)
        {
            this.gameObject.SetActive(false);
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "bullet")
        {
            health = health - 5;
            other.gameObject.SetActive(false);

        }
       
    }
}
