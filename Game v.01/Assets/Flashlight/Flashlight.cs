using UnityEngine;

public class Flashlight : MonoBehaviour
{
    private bool flashlightEnabled;
    public GameObject flashlight;
    public GameObject lightObj;
    private float currentEnergy;

    public void Start()
    {
        
    }

    public void Update()
    {
        //equip
        if (Input.GetKeyDown(KeyCode.F)) 
        {
            flashlightEnabled =! flashlightEnabled;
        }

        if (flashlightEnabled)
        {
            flashlight.SetActive(true);
        }
        else 
        {
            flashlight.SetActive(false);
        }
    }
}
