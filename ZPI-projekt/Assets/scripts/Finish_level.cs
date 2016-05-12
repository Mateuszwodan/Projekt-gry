using UnityEngine;
using System.Collections;

public class Finish_level : MonoBehaviour
{
    public int nastepny;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            Application.LoadLevel(nastepny);
        }
    }
}
