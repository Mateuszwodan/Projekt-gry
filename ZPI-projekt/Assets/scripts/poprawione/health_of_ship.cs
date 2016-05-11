using UnityEngine;
using System.Collections;

public class health_of_ship : MonoBehaviour
{
    public int initial_health = 50;
    int force_of_enemy_bullet = 10;
    int force_of_medkit = 25;
    public UnityEngine.UI.Slider HealthBar;

    void Start()
    {
        HealthBar.value = initial_health;
    }


    void Update()
    {
        if (HealthBar.value <= 0)
        {
            gameObject.SetActive(false);
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
        }
       
    }
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Enemy_bullet")
        {
            HealthBar.value -= force_of_enemy_bullet;
            col.gameObject.SetActive(false);
        }

        if(col.gameObject.tag == "Medkit")
        {
            HealthBar.value += force_of_medkit;
            if (HealthBar.value > 100)
                HealthBar.value = 100;
            col.gameObject.SetActive(false);
        }

        if (col.gameObject.tag == "Laser")
        {
            HealthBar.value = 0;          
        }
    }


}
