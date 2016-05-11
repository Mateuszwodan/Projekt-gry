using UnityEngine;
using System.Collections;

public class load_level : MonoBehaviour {

    public int which_level = 2;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Application.LoadLevel(which_level);
            Debug.Log("Nowy Poziom");
        }
        Debug.Log("Nowy s");
    }
}
