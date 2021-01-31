using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour
{
    public PlayerControl pc;
    public float defense = 100.0f;
    public float max_defense = 100.0f;
    public float fuel = 100.0f;
    public float max_fuel = 100.0f;
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
        fuel_bar.value -=0.02f;
    }


    void UpgradeDefense()
    {
        max_defense += 50f;
        defense_bar.maxValue += 50f;
        defense_bar.value += 50f;
        defense_level++;
    }

    void UpgradeFuelCapacity()
    {
        max_fuel += 50f;
        fuel_bar.value += 50f;
        fuel_bar.maxValue += 50f;
        fuel_level++;
    }

    void SetDefense(float value)
    {
        defense = value;
        defense_bar.value = value;
    }

    void SetFuel(float value)
    {
        fuel = value;
        fuel_bar.value = value;
    }
}
