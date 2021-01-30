using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    public float defense = 5f;
    public float fuel_efficiency = 5f;
    public int defense_level = 1;
    public int fuel_level = 1;

    //Upgrades the defense of the players balloon; dependent on level
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
