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

    public GameObject cannon;
    public GameObject vehicle;

    private int choosen_gun; //1-3
    public int number_of_special_ammo;
    public int number_of_flamethrower_reserve;

    private AudioSource audio_cannon;

        void Start ()
    {
        choosen_gun = 1;
        number_of_special_ammo = 5;
        number_of_flamethrower_reserve = 0;
        set_image_of_weapon();
        audio_cannon = GetComponent<AudioSource>();
    }
	
	void Update () {
        change_weapon();
        shoot();
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
            audio_cannon.Play();
            if (choosen_gun == 1)
            {
                GameObject kula = GameObject.Instantiate(normal_bullet);
                kula.transform.position = cannon.GetComponent<Transform>().position;
                kula.transform.rotation = cannon.GetComponent<Transform>().rotation;
            }
            else if (choosen_gun == 2)
            {
                if (number_of_special_ammo > 0)
                {
                    number_of_special_ammo -= 1;
                    GameObject kula = GameObject.Instantiate(special_bullet);
                    kula.transform.position = cannon.GetComponent<Transform>().position;
                    kula.transform.rotation = cannon.GetComponent<Transform>().rotation;
                    number_of_ammo.GetComponent<Text>().text = number_of_special_ammo.ToString();
                }
            }
            else if (choosen_gun == 3)
            {
                // Tu będzie odpalenie miotacza płomieni
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

}
