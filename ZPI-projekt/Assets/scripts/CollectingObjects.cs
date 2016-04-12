using UnityEngine;
using System.Collections;
using UnityEngine.UI;

class CollectingObjects : MonoBehaviour
{
    public GameObject hostage; // zakładnik
    public GameObject toolbox;
    private int countToolbox;

    void Start()
    {
        countToolbox = 1;
    }

    private void useToolbox()
    {
        if(countToolbox > 0)
        {
            countToolbox--;
            GetComponent<Everything>().health += 5;
        }
    }

    private void displayInfoHostage()
    {
        // wyświetlenie informacji gdzie ma się udać gracz po odbiciu zakładników
    }

    private void displayInfo()
    {
        // wyświetlenie informacji gdzie ma się udać gracz
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Toolbox"))
        {
            countToolbox++;
            Destroy(other.gameObject);
        }

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
    }
}

