using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour
{
    public PlayerControl pc;
    public int defense_level = 1;
    public int fuel_level = 1;

    public Slider fuel_bar;
    public Slider defense_bar;
    public float fuel = 100f;
    public float defense = 100f;

    //Upgrades the defense of the players balloon; dependent on level

    private void Start()
    {
        pc = this.GetComponent<PlayerControl>();
    }

    private void FixedUpdate()
    {
        UpdateFuelBar();
    }

    void UpdateFuelBar()
    {
        if (fuel_bar.value > 0f)
        {
            fuel_bar.value -= 0.02f;
            fuel -= 0.02f;
        }
    }


    public void UpgradeDefense()
    {
        defense_bar.maxValue += 50f;
        defense_bar.value += 50f;
        defense += 50f;
        defense_level++;
    }

    public void UpgradeFuelCapacity()
    {
        fuel_bar.value += 50f;
        fuel_bar.maxValue += 50f;
        fuel += 50f;
        fuel_level++;
    }

    public void SetDefense(float value)
    {
        if (value >= fuel_bar.maxValue)
        {
            defense_bar.value = defense_bar.maxValue;
            defense = defense_bar.maxValue;
        }
        else
        {
            defense_bar.value = value;
            defense = value;
        }
        
    }

    public void SetFuel(float value)
    {
        if (value >= fuel_bar.maxValue)
        {
            fuel_bar.value = fuel_bar.maxValue;
            fuel = fuel_bar.maxValue;
        }
        else
        {
            fuel_bar.value = value;
            fuel = value;
        }
        
    }
}
