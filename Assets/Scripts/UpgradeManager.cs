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

    //Upgrades the defense of the players balloon; dependent on level

    private void Start()
    {
        pc = this.GetComponent<PlayerControl>();
    }

    private void Update()
    {
        UpdateFuelBar();
    }

    void UpdateFuelBar()
    {
        if (fuel_bar.value > 0f)
        {
            fuel_bar.value -= 0.02f;
        }
    }


    void UpgradeDefense()
    {
        defense_bar.maxValue += 50f;
        defense_bar.value += 50f;
        defense_level++;
    }

    void UpgradeFuelCapacity()
    {
        fuel_bar.value += 50f;
        fuel_bar.maxValue += 50f;
        fuel_level++;
    }

    void SetDefense(float value)
    {
        defense_bar.value = value;
    }

    void SetFuel(float value)
    {
        fuel_bar.value = value;
    }
}
