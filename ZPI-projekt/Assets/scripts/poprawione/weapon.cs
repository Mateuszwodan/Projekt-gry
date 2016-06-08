using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class weapon : MonoBehaviour {

    public Sprite gun_1_normal;
    public Sprite gun_2_special;
    public Sprite gun_3_flamethrower;

    public Text number_of_ammo;

    public GameObject normal_bullet;
    public GameObject special_bullet;
    public GameObject flameThrower;

    public GameObject cannon;
    public GameObject vehicle;

    private int choosen_gun; //1-3
    public int number_of_special_ammo;
    public int number_of_flamethrower_reserve;

    private AudioSource audio_cannon;
    public AudioClip audio_clip_cannon;
    public AudioClip audio_clip_flame;

    private bool flame;
    private int wraht_of_flame = 10;
    private int range_of_fire = 10;

    void Start ()
    {
        choosen_gun = 1;
        //number_of_special_ammo = 5;
        //number_of_flamethrower_reserve = 5;
        set_image_of_weapon();
        audio_cannon = GetComponent<AudioSource>();
    }
	
	void Update () {
        change_weapon();
        shoot();
        if (flame)
        {
            fire();
        }
    }



    private void change_weapon()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            choosen_gun = choosen_gun + 1;
            if (choosen_gun == 4)
            {
                choosen_gun = 1;
            }
            set_image_of_weapon();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            choosen_gun = choosen_gun - 1;
            if (choosen_gun == 0)
            {
                choosen_gun = 3;
            }
            set_image_of_weapon();
        }
    }

    private void shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            if (choosen_gun == 1)
            {
                audio_cannon.clip = audio_clip_cannon;
                audio_cannon.Play();
                GameObject kula = GameObject.Instantiate(normal_bullet);
                kula.transform.position = cannon.GetComponent<Transform>().position;
                kula.transform.rotation = cannon.GetComponent<Transform>().rotation;
            }
            else if (choosen_gun == 2)
            {
                if (number_of_special_ammo > 0)
                {
                    audio_cannon.clip = audio_clip_cannon;
                    audio_cannon.Play();
                    number_of_special_ammo -= 1;
                    GameObject kula = GameObject.Instantiate(special_bullet);
                    kula.transform.position = cannon.GetComponent<Transform>().position;
                    kula.transform.rotation = cannon.GetComponent<Transform>().rotation;
                    number_of_ammo.GetComponent<Text>().text = number_of_special_ammo.ToString();
                }
            }
            else if (choosen_gun == 3)
            {
                if (number_of_flamethrower_reserve > 0 && !flame)
                {
                    audio_cannon.clip = audio_clip_flame;
                    audio_cannon.Play();
                    number_of_flamethrower_reserve -= 1;
                    GameObject ft = GameObject.Instantiate(flameThrower);
                    ft.transform.position = cannon.GetComponent<Transform>().position;
                    ft.transform.rotation = cannon.GetComponent<Transform>().rotation;
                    number_of_ammo.GetComponent<Text>().text = number_of_flamethrower_reserve.ToString();
                    flame = true;
                    StartCoroutine(WaitForEndOfFire(3.0F));
                }
            }

        }
    }

    void set_image_of_weapon()
    {
        if (choosen_gun == 1)
        {
            gameObject.GetComponent<Image>().sprite = gun_1_normal;
            number_of_ammo.GetComponent<Text>().text = "X";
        }
        if (choosen_gun == 2)
        {
            gameObject.GetComponent<Image>().sprite = gun_2_special;
            number_of_ammo.GetComponent<Text>().text = number_of_special_ammo.ToString();
        }
        if (choosen_gun == 3)
        {
            gameObject.GetComponent<Image>().sprite = gun_3_flamethrower;
            number_of_ammo.GetComponent<Text>().text = number_of_flamethrower_reserve.ToString();
        }
    }
    private void fire()
    {
        Ray ray = new Ray(cannon.transform.position , cannon.transform.TransformDirection(Vector3.forward) * 5);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, range_of_fire))
        {
            Debug.Log("Co trafilem: " + hit.collider.name);
            if  (hit.collider.tag == "Enemy")
            {
                hit.collider.GetComponent<enemy_health>().health -= wraht_of_flame;            
            }
        }
            
    }

    IEnumerator WaitForEndOfFire(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        flame = false;
        // Stop particle system
    }
}
