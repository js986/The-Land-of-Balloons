using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlchemyMain : MonoBehaviour
{
    //This class should handle transmutations

    int GreenGas = 0; //Fuel [Pull from player] 
    int RedGas = 0;   //Horizontal Speed increase [Pull from player]
    int BlueGas = 0;  //Up and down speed increase [Pull from player]
    enum GasType
    {
        Green,
        Red,
        Blue
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Transmutes from type to other type
    void transmute(GasType a,GasType b)
    {
        if (a == b) return;
        switch (a)
        {
            case GasType.Green:
                GreenGas--;
                GreenGas--;
                break;
            case GasType.Red:
                RedGas--;
                RedGas--;
                break;
            case GasType.Blue:
                BlueGas--;
                BlueGas--;
                break;
        }

        switch (b)
        {
            case GasType.Green:
                GreenGas++;
                break;
            case GasType.Red:
                RedGas++;
                break;
            case GasType.Blue:
                BlueGas++;
                break;
        }

    }
}
