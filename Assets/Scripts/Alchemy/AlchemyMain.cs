using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class AlchemyMain : MonoBehaviour
{
    //This class should handle transmutations and UI

    int GreenGas = 0; //Fuel [Pull from player] 
    int RedGas = 0;   //Horizontal Speed increase [Pull from player]
    int BlueGas = 0;  //Up and down speed increase [Pull from player]

    UpgradeManager shop;

    public int conversitionFactor = 5;
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
    [SerializeField] Sprite[] gasSprites = new Sprite[3];
    [SerializeField] Image left;
    [SerializeField] Image current;
    [SerializeField] Image right;

    public enum TradeType
    {
        Repair,
        Refuel,
        UpgradeDefense,
        UpgradeEngine,
    }
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
        shop = GameObject.FindGameObjectWithTag("Player").GetComponent<UpgradeManager>();
    }

    // Update is called once per frame
    void Update()
    {
        GreenGas = PickupManager.instance.green_counter;
        RedGas = PickupManager.instance.red_counter;
        BlueGas = PickupManager.instance.blue_counter;

        //Testing system with placeholder controls bare with me
        //switchCurrentGas(false);
        if(Keyboard.current.spaceKey.isPressed && !Keyboard.current.leftShiftKey.isPressed) convertCurrentGas(false);
        else if (Keyboard.current.spaceKey.isPressed && Keyboard.current.leftShiftKey.isPressed) convertCurrentGas(true);

        if (Keyboard.current.qKey.wasPressedThisFrame) switchCurrentGas(true);
        else if (Keyboard.current.eKey.wasPressedThisFrame) switchCurrentGas(false);

        if (Keyboard.current.uKey.wasPressedThisFrame) upgradeTransaction(TradeType.Refuel);
        if (Keyboard.current.iKey.wasPressedThisFrame) upgradeTransaction(TradeType.Repair);
        if (Keyboard.current.oKey.wasPressedThisFrame) upgradeTransaction(TradeType.UpgradeDefense);
        if (Keyboard.current.pKey.wasPressedThisFrame) upgradeTransaction(TradeType.UpgradeEngine);
        /*
        if (Input.GetKeyDown(KeyCode.A)) switchCurrentGas(false);
        else if (Input.GetKeyDown(KeyCode.D)) switchCurrentGas(true);

        if (Input.GetKeyDown(KeyCode.Q)) convertCurrentGas(false);
        else if (Input.GetKeyDown(KeyCode.E)) convertCurrentGas(true);
        */

        PickupManager.instance.green_counter = GreenGas;
        PickupManager.instance.red_counter = RedGas;
        PickupManager.instance.blue_counter = BlueGas;
    }
    //Transmutes from type to other type
    void transmute(GasType a,GasType b)
    {
        if (a == b) return;
        bool cantrade = true;
        switch (a)
        {
            case GasType.Green:
                if (GreenGas <= conversitionFactor-1)
                {
                    cantrade = false;
                    break;
                }
                GreenGas -= conversitionFactor;
                break;
            case GasType.Red:
                if (RedGas <= conversitionFactor - 1)
                {
                    cantrade = false;
                    break;
                }
                RedGas -= conversitionFactor;
                break;
            case GasType.Blue:
                if (BlueGas <= conversitionFactor - 1)
                {
                    cantrade = false;
                    break;
                }
                BlueGas-= conversitionFactor;
                break;
        }

        switch (b)
        {
            case GasType.Green:
                if (!cantrade) break;
                GreenGas++;
                break;
            case GasType.Red:
                if (!cantrade) break;
                RedGas++;
                break;
            case GasType.Blue:
                if (!cantrade) break;
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
                else transmute(GasType.Blue, GasType.Green);
                break;
        }
    }

    //Switch current gas to something on the left or the right of the current gas
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
        //Update images based on new curGas
        switch (currGas)
        {
            case GasType.Green:
                left.sprite = gasSprites[0];
                current.sprite = gasSprites[1];
                right.sprite = gasSprites[2];
                break;
            case GasType.Red:
                left.sprite = gasSprites[2];
                current.sprite = gasSprites[0];
                right.sprite = gasSprites[1];
                break;
            case GasType.Blue:
                left.sprite = gasSprites[1];
                current.sprite = gasSprites[2];
                right.sprite = gasSprites[0]; 
                break;
        }

    }

    void upgradeTransaction(TradeType trade)
    {
        switch (trade)
        {
            case TradeType.Refuel:
                if (RedGas > 0) {
                    RedGas--;
                    shop.fuel += 1;
                }
                break;

            case TradeType.Repair:
                if (RedGas >0 && BlueGas > 0)
                {
                    RedGas--;
                    BlueGas--;
                    shop.defense += 1;
                }
                break;

            case TradeType.UpgradeDefense:
                if (GreenGas > 10 && BlueGas > 10)
                {
                    GreenGas -=10;
                    BlueGas -=10;
                    shop.UpgradeDefense();
                }
                break;

            case TradeType.UpgradeEngine:
                if (GreenGas > 10 && RedGas > 10)
                {
                    RedGas -= 10;
                    GreenGas -= 10;
                    shop.UpgradeFuelCapacity();
                }
                break;
        }
    }
}