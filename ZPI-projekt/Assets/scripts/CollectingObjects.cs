using UnityEngine;
using System.Collections;
using UnityEngine.UI;

class CollectingObjects : MonoBehaviour
{
    public GameObject hostage; // zakładnik
    public GameObject ammo2;
    public GameObject ammo3;

    private void displayInfoHostage()
    {
        // wyświetlenie informacji gdzie ma się udać gracz po odbiciu zakładników
    }

    private void displayInfo()
    {
        // wyświetlenie informacji gdzie ma się udać gracz
        string trescMisji = "";
        string nazwaSceny = Application.loadedLevelName;

        if(nazwaSceny.Equals("Przedmiescia"))
        {
            trescMisji = "Przedmiescia - info";
        }

        if (nazwaSceny.Equals("Srodmiescie"))
        {
            trescMisji = "Srodmiescie - info";
        }

        if (nazwaSceny.Equals("Centrum"))
        {
            trescMisji = "Centrum - info";
        }

        if (nazwaSceny.Equals("Pomocnicza"))
        {
            trescMisji = "Pomocnicza - info";
        }

        GetComponent<back_to_game>().setTekstMisji(trescMisji);
    }

    private void addAmmo2()
    {
        // dodanie amunicji do drugiej broni
        //GetComponent<changeWeapon>().ammo2 += 10;
    }

    private void addAmmo3()
    {
        // dodanie amunicji do trzeciej broni
        //GetComponent<changeWeapon>().ammo3 += 10;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Hostage"))
        {
            displayInfoHostage();
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Info"))
        {
            displayInfo();
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
    }
}

