using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

class collecting_equipment : MonoBehaviour
{
    //public GameObject hostage; // zakładnik
    //public GameObject special_ammo;
    //public GameObject flamethrower_ammo;
    public GameObject information_about_hostage;
    public GameObject information_about_mission;
    public Text number_of_bridges_text;
    public pop_up_menu menu;

    public int number_of_bridges = 0;


    void Start()
    {
        initial_info();
        information_about_hostage.SetActive(false);
        information_about_mission.SetActive(false);
        addBridge(0);
        //menu = GetComponent<pop_up_menu>();
    }

    private void show_hostage_information()
    {
        string objective_content = "";
        objective_content = "Uciekaj z centrum";
        menu.set_mission_text(objective_content);
        information_about_hostage.gameObject.SetActive(true);
    }

    private void show_information()
    {
        string objective_content = "";
        objective_content = "Udaj sie do centrum";
        menu.set_mission_text(objective_content);
        information_about_mission.gameObject.SetActive(true);
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

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Hostage"))
        {
            show_hostage_information();
            other.gameObject.SetActive(false);
        }

        if (other.gameObject.tag == "Info")
        {
            show_information();
            other.gameObject.SetActive(false);
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
            objective_content = "Dojedz do konca drogi i nie daj sie zabic przez wrogow";
        }

        if (name_of_scene.Equals("Srodmiescie"))
        {
            objective_content = "Zdobadz informacje o dokladnym polozeniu zakladnikow i ruszaj w strone centrum";
        }

        if (name_of_scene.Equals("Centrum"))
        {
            objective_content = "Uratuj zakladnikow i uciekaj";
        }

        if (name_of_scene.Equals("Pomocnicza"))
        {
            objective_content = "Pomocnicza - info";
        }

        menu.set_mission_text(objective_content);
    }

}

