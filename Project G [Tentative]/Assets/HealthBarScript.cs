using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthBarScript : MonoBehaviour
{
    public Slider slider;


    public void SetHealth(int health)
    {
        slider.value = health;
    }

    public void SetMaxHealth(int health)//Sets the max health of the healthbar at the start
    {
        slider.maxValue = health;
        slider.value = health;
    }
}
