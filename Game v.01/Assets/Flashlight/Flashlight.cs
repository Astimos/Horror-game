using UnityEngine;

public class Flashlight : MonoBehaviour
{
    private bool flashlightEnabled;
    public GameObject flashlight;
    public GameObject lightObj;
    private float currentEnergy;
    public float maxEnergy;

    private float batteries;
    private GameObject batteryPickedUp;
    private float usedEnergy;


    public void Start()
    {
        currentEnergy = maxEnergy;
        maxEnergy = 50 * batteries;
    }

    public void FixedUpdate()
    {

        maxEnergy = 50 * batteries;
        currentEnergy = maxEnergy;


        //Turn on|off by pressing F

        if (Input.GetKeyDown(KeyCode.F)) 
        {
            flashlightEnabled =! flashlightEnabled;
        }

        /* Enabling flashling

        if (flashlightEnabled)
       {
             flashlight.SetActive(true);
      }
        else 
       {
          flashlight.SetActive(false);
        }

        */


        if (flashlightEnabled)
        {
            flashlight.SetActive(true);


            currentEnergy -= 0.5f * Time.deltaTime;
            if (currentEnergy <= 0) 
            {
                lightObj.SetActive(false);
                batteries = 0;
            }
            if (currentEnergy > 0) 
            {
                lightObj.SetActive(true);
                currentEnergy -= 0.5f * Time.deltaTime;
                usedEnergy += 10f * Time.deltaTime;
            }

            if (usedEnergy >= 50) 
            {
                batteries -= 1;
                usedEnergy = 0;
            }
        }

        else 
        {
             flashlight.SetActive(false);
        }

        print("Batteires: " + batteries);
        print("usedEnergy: " + usedEnergy);
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Battery") {
            batteryPickedUp = other.gameObject;
            batteries += 1;
            Destroy(batteryPickedUp);
        }
    }
}
