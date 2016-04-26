using UnityEngine;
using System.Collections;

public class DestroyWall : MonoBehaviour {

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Burzacy")
        {
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}
