using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlchemyMain : MonoBehaviour
{
    //This class should handle transmutations and UI

    int GreenGas = 0; //Fuel [Pull from player] 
    int RedGas = 0;   //Horizontal Speed increase [Pull from player]
    int BlueGas = 0;  //Up and down speed increase [Pull from player]
    /*Idea of what the icon layout is going to be like
     *        ________
     * ___    |       |   ___ 
     * |__|   |       |   |__|
     *        |_______|   
     * 
     * 
     */
    //Central icon is currently selected gas (the gas you want to convert)
    //On each side of the icon are the two other gases. When you press a button you convert to the other gases
    enum GasType
    {
        Green,
        Red,
        Blue
    }
    GasType currGas = GasType.Green;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GreenGas = PickupManager.instance.green_counter;
        RedGas = PickupManager.instance.red_counter;
        BlueGas = PickupManager.instance.blue_counter;
    }
    //Transmutes from type to other type
    void transmute(GasType a,GasType b)
    {
        if (a == b) return;
        switch (a)
        {
            case GasType.Green:
                if (GreenGas <= 1) break; 
                GreenGas--;
                GreenGas--;
                break;
            case GasType.Red:
                if (RedGas <= 1) break;
                RedGas--;
                RedGas--;
                break;
            case GasType.Blue:
                if (BlueGas <= 1) break;
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

    //Converts currently selected gas to new gas type
    public void convertCurrentGas(bool LorR) //false is left input, true is right input
    {
        switch (currGas) 
        {
            case GasType.Green:
                if (LorR) transmute(GasType.Green, GasType.Blue);
                else transmute(GasType.Green, GasType.Red);
                break;
            case GasType.Red:
                if (LorR) transmute(GasType.Red, GasType.Green);
                else transmute(GasType.Red, GasType.Blue);
                break;
            case GasType.Blue:
                if (LorR) transmute(GasType.Blue, GasType.Red);
                else transmute(GasType.Red, GasType.Green);
                break;
        }
    }

    public void switchCurrentGas(bool LorR) //false is left input, true is right input
    {
        switch (currGas)
        {
            case GasType.Green:
                if (LorR) currGas = GasType.Blue;
                else currGas = GasType.Red;
                break;
            case GasType.Red:
                if (LorR) currGas = GasType.Green;
                else currGas = GasType.Blue;
                break;
            case GasType.Blue:
                if (LorR) currGas = GasType.Red;
                else currGas = GasType.Green;
                break;
        }
    }



}
