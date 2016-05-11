using UnityEngine;
using System.Collections;

public class destroy_wall : MonoBehaviour {

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Burzacy")
        {
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}
