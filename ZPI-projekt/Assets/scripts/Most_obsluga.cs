using UnityEngine;
using System.Collections;

public class Most_obsluga : MonoBehaviour {

    public Renderer rer1;
    public Renderer rer2;
    public GameObject player;
    public BoxCollider coli;
    // Use this for initialization
    void Start () {
        rer1.enabled = false;
        rer2.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.T))
        {
            if (Vector3.Distance(player.transform.position, transform.position) < 30f)
            {
                rer1.enabled = true;
                rer2.enabled = true;
                coli.size = new Vector3(17.0f, 0f, 70.0f);
            }
        }
    }
     
}
