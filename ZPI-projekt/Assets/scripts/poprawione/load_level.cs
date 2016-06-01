using UnityEngine;
using System.Collections;

public class load_level : MonoBehaviour {

    public GameObject info;
    void OnCollisionEnter(Collision other)
    {
        string name_of_scene = Application.loadedLevelName;

        if (name_of_scene.Equals("Przedmiescia"))
        {
            if (other.gameObject.tag == "Player")
            {
                Application.LoadLevel("Srodmiescie");
              
            }
        }

        if (name_of_scene.Equals("Srodmiescie") && info.active == false)
        {
            if (other.gameObject.tag == "Player")
            {
                Application.LoadLevel("Centrum");

            }
        }

        if (name_of_scene.Equals("Centrum"))
        {
            if (other.gameObject.tag == "Player")
            {
                Application.LoadLevel("Napisy_koncowe");

            }
        }

    }
}
