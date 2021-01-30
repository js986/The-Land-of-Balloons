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
        
    }

    void UpdateBar(Slider bar, float magnitude)
    {
        
    }


    void UpgradeDefense()
    {
        max_defense += 2f;
        defense_level++;
    }

    void UpgradeFuelCapacity()
    {
        max_fuel += 50f;
        fuel_level++;
    }
}
