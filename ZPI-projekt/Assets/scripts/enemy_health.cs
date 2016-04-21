using UnityEngine;
using System.Collections;

public class enemy_health : MonoBehaviour {

    public int health = 100;
    public int pocisk = 15;
    public int burzacy = 25;

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
        if (other.gameObject.tag == "Pocisk")
        {
            health = health - pocisk;
            other.gameObject.SetActive(false);
            Debug.Log("Trafion");

        }
        if (other.gameObject.tag == "Burzacy")
        {
            health = health - burzacy;
            other.gameObject.SetActive(false);

        }
    }
}
