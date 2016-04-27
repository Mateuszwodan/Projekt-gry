using UnityEngine;
using System.Collections;

public class timeBomb : MonoBehaviour {

    public float range_of_enemy = 15f;
    public float range_of_boom = 30f;
    public GameObject player;
    public GameObject explosion;

    void Update () {
        if (Vector3.Distance(player.transform.position, transform.position) < range_of_enemy)
        {
            StartCoroutine(boom());
        }

    }

    private IEnumerator boom()
    {
        yield return new WaitForSeconds(3f);
        if (Vector3.Distance(player.transform.position, transform.position) < range_of_boom)
        {
            // Tu gracz traci życie
            GameObject exp = GameObject.Instantiate(explosion);
            exp.transform.position = this.GetComponent<Transform>().position;
            exp.transform.rotation = this.GetComponent<Transform>().rotation;

        }
        gameObject.SetActive(false);
    }
}
