using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

class collecting_equipment : MonoBehaviour
{
    public GameObject hostage; // zakładnik
    public GameObject special_ammo;
    public GameObject flamethrower_ammo;
    public GameObject information_about_hostage;
    public GameObject information_about_mission;
    public Text number_of_bridges_text;

    public int number_of_bridges = 0;


    void Start()
    {
        initial_info();
        information_about_hostage.SetActive(false);
        information_about_mission.SetActive(false);
        addBridge(0);
    }

    private void show_hostage_information()
    {
        string objective_content = "";
        objective_content = "Zmienione info po wzięciu zakładników";
        GetComponent<pop_up_menu>().set_mission_text(objective_content);
    }

    private void show_information()
    {
        string objective_content = "";
        objective_content = "Zmienione info po pierwszej części";
        GetComponent<pop_up_menu>().set_mission_text(objective_content);
    }

    private void addBridge(int new_most)
    {
        number_of_bridges += new_most;
        number_of_bridges_text.text = number_of_bridges.ToString();
    }


    private void addAmmo2()
    {
        GetComponent<weapon>().number_of_special_ammo += 5;
    }

    private void addAmmo3()
    {
        GetComponent<weapon>().number_of_flamethrower_reserve += 10;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Hostage"))
        {
            show_hostage_information();
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Info"))
        {
            show_information();
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Ammo2"))
        {
            addAmmo2();
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Ammo3"))
        {
            addAmmo3();
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Bridge"))
        {
            addBridge(1);
            Destroy(other.gameObject);
        }
    }

    private void initial_info()
    {
        string objective_content = "";
        string name_of_scene = Application.loadedLevelName;

        if (name_of_scene.Equals("Przedmiescia"))
        {
            objective_content = "Przedmiescia - info";
        }

        if (name_of_scene.Equals("Srodmiescie"))
        {
            objective_content = "Srodmiescie - info";
        }

        if (name_of_scene.Equals("Centrum"))
        {
            objective_content = "Centrum - info";
        }

        if (name_of_scene.Equals("Pomocnicza"))
        {
            objective_content = "Pomocnicza - info";
        }

        GetComponent<pop_up_menu>().set_mission_text(objective_content);
    }
}

