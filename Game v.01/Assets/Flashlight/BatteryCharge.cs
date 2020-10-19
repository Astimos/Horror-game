using UnityEngine;
using UnityEngine.UI;

public class BatteryCharge : MonoBehaviour
{

    public Slider slider;


    private static float maxchargeValue;
    private static float EnergyValue;

    
    public void SetMaxCharge(int charge) 
    {
        slider.maxValue = maxchargeValue;
        slider.value = maxchargeValue;

    }

    void Update()
    {
        maxchargeValue = Flashlight.maxEnergy;
        EnergyValue = Flashlight.usedEnergy;
        print("MAXSLIDERVALUE: " + maxchargeValue);
        print("CURRENTENERGYVALUE: " + EnergyValue);
    }

    
}
 