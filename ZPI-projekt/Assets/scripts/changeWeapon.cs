using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class changeWeapon : MonoBehaviour {

    public Sprite gun1;
    public Sprite gun2;
    public Sprite gun3;
    public Text ammo;
    public GameObject bullet;
    public GameObject bullet2;
    public GameObject cannon;
    public GameObject vehicle;

    private int gun;
    private int ammo2;
    private int ammo3;





        // Use this for initialization
        void Start () {
        gun = 1;
        ammo2 = 1;
        ammo3 = 0;
        changeWeap();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            gun = gun + 1;
            if (gun == 4)
            {
                gun = 1;
            }
            changeWeap();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            gun = gun - 1;
            if (gun == 0)
            {
                gun = 3;
            }
            changeWeap();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Tu dodaj efekt wystrzału
            if (gun == 1)
            {
                GameObject kula = GameObject.Instantiate(bullet);
                kula.transform.position = cannon.GetComponent<Transform>().position;
                kula.transform.rotation = cannon.GetComponent<Transform>().rotation;
            }
            else if (gun == 2)
            {
                if (ammo2 > 0)
                {
                    ammo2 -= 1;
                    GameObject kula = GameObject.Instantiate(bullet2);
                    kula.transform.position = cannon.GetComponent<Transform>().position;
                    kula.transform.rotation = cannon.GetComponent<Transform>().rotation;
                    ammo.GetComponent<Text>().text = ammo2.ToString();
                }
            }
            // Tu będzie odpalenie miotacza płomieni
        }
    }

    void changeWeap()
    {
        if (gun == 1)
        {
            gameObject.GetComponent<Image>().sprite = gun1;
            ammo.GetComponent<Text>().text = "X";
        }
        if (gun == 2)
        {
            gameObject.GetComponent<Image>().sprite = gun2;
            ammo.GetComponent<Text>().text = ammo2.ToString();
        }
        if (gun == 3)
        {
            gameObject.GetComponent<Image>().sprite = gun3;
            ammo.GetComponent<Text>().text = ammo3.ToString();
        }
    }

}
