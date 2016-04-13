using UnityEngine;
using System.Collections;

public class Everything : MonoBehaviour
{
    public int health;
    public UnityEngine.UI.Slider HealthBar;
    // Use this for initialization
    void Start()
    {
        health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        HealthBar.value = health;
        if (health <= 0)
        {
            gameObject.SetActive(false);
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy_bullet")
        {
            health = health - 5;
            
            other.gameObject.SetActive(false);
           
        }
    }
}
