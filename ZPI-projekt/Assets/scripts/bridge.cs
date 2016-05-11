using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class bridge : MonoBehaviour {

    public Renderer rer1;
    public Renderer rer2;
    public GameObject player;
    public BoxCollider collider;
    public Text number_of_bridge;

    private float distance = 30.0f;

    void Start ()
    {
        rer1.enabled = false;
        rer2.enabled = false;
	}
	
	void Update () {

        if (Input.GetKey(KeyCode.T))
        {
            if (Vector3.Distance(player.transform.position, transform.position) < distance)
            {
                rer1.enabled = true;
                rer2.enabled = true;
                collider.size = new Vector3(17.0f, 0f, 70.0f);
            }
        }
    }
     
}
