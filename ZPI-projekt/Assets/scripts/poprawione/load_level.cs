using UnityEngine;
using System.Collections;

public class load_level : MonoBehaviour {

    public int which_level = 2;
    public void Loads()
    {
        Application.LoadLevel(which_level);
    }
}
