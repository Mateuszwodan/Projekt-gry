using UnityEngine;
using System.Collections;

public class enemy_health : MonoBehaviour {

    public int health = 100;
    public int normal_wound = 15;
    public int special_wound = 25;

	void Update ()
    {
        if (health <= 0)
        {
            this.gameObject.SetActive(false);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Pocisk")
        {
            health = health - normal_wound;
            other.gameObject.SetActive(false);
        }

        if (other.gameObject.tag == "Burzacy")
        {
            health = health - special_wound;
            other.gameObject.SetActive(false);
        }
    }
}
