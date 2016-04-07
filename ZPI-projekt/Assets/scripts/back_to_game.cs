using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class back_to_game : MonoBehaviour
{
    public GameObject MainMenu; //Canvas
    public GameObject Przyc1; //Przycisk powrotu do gry
    public GameObject Przyc2; //Przycisk powrtu do menu
    public GameObject Przyc3; //Przycisk pokazania celow misji
    public GameObject opisMisji; //okno celu misji
    public Text tekstmisji; //tekst celu misji
    string trescMisji = " jakas tresc misji";
    bool showMission = false;
    // Use this for initialization
    void Start()
    {
        opisMisji.SetActive(false);
        HandleMenu();
        tekstmisji.text = trescMisji;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            HandleMenu();          
        }
        
    }

    public void HandleMenu()
    {
       if(showMission)
        {
            opisMisji.SetActive(!opisMisji.activeSelf);
            showMission = !showMission;
        }
            //toogle input
            

            //toogle menu
            
            Przyc1.SetActive(!Przyc1.activeSelf);
            Przyc2.SetActive(!Przyc2.activeSelf);
            Przyc3.SetActive(!Przyc3.activeSelf);


    }
    public void mission()
    {
        if(showMission == false)
        {
            opisMisji.SetActive(!opisMisji.activeSelf);
            showMission = !showMission;
            Przyc1.SetActive(false);
            Przyc2.SetActive(false);
            Przyc3.SetActive(false);
        }
    }
   

}
