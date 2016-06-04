using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class health_of_ship : MonoBehaviour
{
    public int initial_health = 50;
    int force_of_enemy_bullet = 10;
    int force_of_medkit = 25;
    public UnityEngine.UI.Slider HealthBar;
    GameObject screen_fadder;
    public float fadeSpeed = 1f;          // Speed that the screen fades to and from black.
    private bool sceneStarting = true;      // Whether or not the scene is still fading in.
    float timer = 0;

    void Start()
    {
        HealthBar.value = initial_health;
        screen_fadder = GameObject.FindWithTag("Fadder");
        screen_fadder.SetActive(true);
    }

    void Awake()
    {
        // Set the texture so that it is the the size of the screen and covers it.
        
    }
    public void EndScene()
    {
        GameObject.FindWithTag("Fadder").SetActive(true);
        Image img = GameObject.FindWithTag("Fadder").GetComponent<Image>();
        img.color = Color.Lerp(img.color, new Color(0, 0, 0, 1f), Time.deltaTime*fadeSpeed);
        if (img.color.a >= 0.9f)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
        }

    }
    void Update()
    {
        if (sceneStarting)
        {
            Image img = GameObject.FindWithTag("Fadder").GetComponent<Image>();
            img.color = Color.Lerp(img.color, new Color(0, 0, 0, 0f), Time.deltaTime*fadeSpeed);
            if(img.color.a <= 0.01f)
            {
                sceneStarting = false;
                GameObject.FindWithTag("Fadder").SetActive(false);
            }
        }
        if (HealthBar.value <= 0)
        {
            EndScene();
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
