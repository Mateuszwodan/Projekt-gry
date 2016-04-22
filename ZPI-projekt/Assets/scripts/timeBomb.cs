using UnityEngine;
using System.Collections;

public class timeBomb : MonoBehaviour {

    public float range_of_enemy = 15f;
    public float range_of_boom = 30f;
    public GameObject player;

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
        }
        gameObject.SetActive(false);
    }
}
