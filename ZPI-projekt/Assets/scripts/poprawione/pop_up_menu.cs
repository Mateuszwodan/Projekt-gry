using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class pop_up_menu : MonoBehaviour
{
    public GameObject canvas_menu; 
    public GameObject button_back_to_game; 
    public GameObject button_back_to_menu; 
    public GameObject button_describe_of_objective; 
    public GameObject button_reset_level; 
    public GameObject window_describe_of_objective; 
    public Text mission_text; 
    public string mission_string = " jakas tresc misji";

    bool if_show_mission = false;

    void Start()
    {
        window_describe_of_objective.SetActive(false);
        show_menu();
        mission_text.text = mission_string;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            show_menu();          
        }
        mission_text.text = mission_string;
    }

    public void set_mission_text(string text)
    {
        mission_string = text;
    }

    public void show_menu()
    {
       if(if_show_mission)
        {
            window_describe_of_objective.SetActive(!window_describe_of_objective.activeSelf);
            if_show_mission = !if_show_mission;
        }
            
            button_back_to_game.SetActive(!button_back_to_game.activeSelf);
            button_back_to_menu.SetActive(!button_back_to_menu.activeSelf);
            button_describe_of_objective.SetActive(!button_describe_of_objective.activeSelf);
            button_reset_level.SetActive(!button_reset_level.activeSelf);


    }
    public void show_mission()
    {
        if(if_show_mission == false)
        {
            window_describe_of_objective.SetActive(!window_describe_of_objective.activeSelf);
            if_show_mission = !if_show_mission;
            button_back_to_game.SetActive(false);
            button_back_to_menu.SetActive(false);
            button_describe_of_objective.SetActive(false);
            button_reset_level.SetActive(false);
        }
    }

    public void back_to_menu()
    {
        Application.LoadLevel(0);
    }

    public void reset_level()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
    }
}
