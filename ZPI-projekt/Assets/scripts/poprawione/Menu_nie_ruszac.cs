using UnityEngine;
using System.Collections;

public class Menu_nie_ruszac : MonoBehaviour {

    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void StartGame()
    {
        Application.LoadLevel(1);
    }
    public void Ending_text()
    {
        Application.LoadLevel(5);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
