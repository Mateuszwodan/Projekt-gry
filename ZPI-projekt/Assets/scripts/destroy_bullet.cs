using UnityEngine;
using System.Collections;

public class destroy_bullet : MonoBehaviour {

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Pocisk")
        {
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.tag == "Burzacy")
        {
            other.gameObject.SetActive(false);
        }
    }
}
