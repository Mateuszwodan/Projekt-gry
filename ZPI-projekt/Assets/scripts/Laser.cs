using UnityEngine;
using System.Collections;

public class Laser : MonoBehaviour {
    bool kierunek = true;
    int zakres;
    public Renderer rer;
    public BoxCollider col;
    int licznik = 0;
   
	// Use this for initialization
	void Start () {
        zakres = 100;
       
	}
	
	// Update is called once per frame
	void Update () {
        if (kierunek)
        {
            if (licznik < zakres)
            {
                rer.enabled = true;
                col.enabled = true;
                licznik++;
            }
            else
            {
                licznik = 0;
                kierunek = !kierunek;
            }
        }
        else
        {
            if (licznik < zakres)
            {
                rer.enabled = false;
                col.enabled = false;
                licznik++;
            }
            else
            {
                licznik = 0;
                kierunek = !kierunek;
            }
        }
    }
}
