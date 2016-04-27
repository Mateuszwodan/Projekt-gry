using UnityEngine;
using System.Collections;

public class Everything : MonoBehaviour
{
    public int health;
    public UnityEngine.UI.Slider HealthBar;
    // Use this for initialization
    void Start()
    {
        health = 50;
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
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Enemy_bullet")
        {
            health -= 10;
            col.gameObject.SetActive(false);
        }
        if(col.gameObject.tag == "Medkit")
        {
            health += 25;
            if (health > 100)
                health = 100;
            col.gameObject.SetActive(false);
        }
        if (col.gameObject.tag == "Laser")
        {
            health = 0;
          
        }
    }


}
