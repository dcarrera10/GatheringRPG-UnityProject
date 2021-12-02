using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;

    //Setting the minimum and maximum value of the slider.
    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }
    
    //Creates the slider value as the health value that is put in.
    public void SetHealth(int health)
    {
        slider.value = health;
    }

}
