using UnityEngine;
using System.Collections;
using System;

public class update_position_of_gui : MonoBehaviour {

    public GameObject life_slider;
    public GameObject number_of_bridges;
    public GameObject image_of_bridge;
    public GameObject volume_slider;
    public GameObject turn_music_button_slash_image;
    public GameObject weapon_image;
    public GameObject number_of_ammo;
    public GameObject information_image;
    public GameObject hostage_image;

	void Start () {
        update_position();
	}

    private void update_position()
    {
        float h = Screen.height;
        float w = Screen.width;

        life_slider.transform.localPosition = new Vector3(-w/2+80, -h/2+30, 0f);

        number_of_bridges.transform.localPosition = new Vector3(-w / 2 + 210, -h / 2 + 80, 0f);
        image_of_bridge.transform.localPosition = new Vector3(-w / 2 + 80, -h / 2 + 80, 0f);

        volume_slider.transform.localPosition = new Vector3(-w / 2 + 80, h / 2 - 20, 0f);
        turn_music_button_slash_image.transform.localPosition = new Vector3(-w / 2 + 210, h / 2 - 40, 0f);

        weapon_image.transform.localPosition = new Vector3(w / 2 - 100, -h / 2 + 100, 0f);
        number_of_ammo.transform.localPosition = new Vector3(w / 2 - 100, -h / 2 + 30, 0f);

        information_image.transform.localPosition = new Vector3(w / 2 - 80, h / 2 - 80, 0f);
        hostage_image.transform.localPosition = new Vector3(w / 2 - 80, h / 2 - 80, 0f);
    }

    void Update () {
        if (Input.GetKeyDown(KeyCode.V))
        {
            update_position();
        }
    }
}
