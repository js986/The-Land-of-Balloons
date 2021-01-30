using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour
{
    public PlayerControl pc;
    public float defense = 5f;
    public float max_defense = 5f;
    public float fuel_efficiency = 5f;
    public float max_fuel_efficiency = 5f;
    public int defense_level = 1;
    public int fuel_level = 1;

    public Image fuel_bar;
    public Image defense_bar;

    //Upgrades the defense of the players balloon; dependent on level

    private void Start()
    {
        pc = this.GetComponent<PlayerControl>();
    }
    void UpgradeDefense()
    {
        defense += 2f;
        defense_level++;
    }

    void UpgradeFuel()
    {
        fuel_efficiency += 2f;
        fuel_level++;
    }
}
