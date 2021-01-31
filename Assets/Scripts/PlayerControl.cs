using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static AlchemyMain;
using static MasterControls;

public class PlayerControl : MonoBehaviour, IMainActions
{
    MasterControls input;
    public bool moveable = true;

    [SerializeField]
    Vector2 _movementInput;
    float _gasConvertInput;
    // float _gasSwitchInput;

    public float vertical_boost;
    public float horizontal_boost;

    [SerializeField] Vector2 _movementSpeedScale = new Vector2(1,1);
    [SerializeField] Sprite[] sprites = new Sprite[5];
    SpriteRenderer _sr;
    Rigidbody2D _rb;
    AlchemyMain _alchemySystem;

    void Awake()
    {
        input = new MasterControls();
        input.Main.SetCallbacks(this);
    }
    void Start(){
        _rb = GetComponent<Rigidbody2D>();
        _sr = GetComponent<SpriteRenderer>();
        _alchemySystem = GetComponent<AlchemyMain>();
        _sr.sprite = sprites[0];
    }
    private void OnEnable(){
        input.Enable();
    }
    private void OnDisable(){
        input.Disable();
    }

    void FixedUpdate(){

        if (!moveable){
            _rb.velocity = Vector3.zero;
            return;
            }
        //vertical_boost = PickupManager.instance.blue_counter/100;
        //horizontal_boost = PickupManager.instance.green_counter/100;
        vertical_boost = Mathf.Exp(0.0009f * PickupManager.instance.blue_counter);
        horizontal_boost = Mathf.Exp(0.0009f * PickupManager.instance.green_counter);

        if (_movementInput.x < 0)
        {
            _sr.sprite = sprites[1];
        }
        else if (_movementInput.x > 0)
        {
            _sr.sprite = sprites[2];
        }
        else if (_movementInput.y > 0)
        {
            _sr.sprite = sprites[3];
        }
        else
        {
            _sr.sprite = sprites[0];
        }

        transform.Translate(
            _movementInput.x * (horizontal_boost * _movementSpeedScale.x), 
            _movementInput.y * (vertical_boost * _movementSpeedScale.y), 
            0
        );

        if (_movementInput.y > 0)
            _rb.velocity = Vector2.zero;

        // Gas conversion/switching input
        if (_gasConvertInput > 0){
                    print(_gasConvertInput);

            _alchemySystem.convertCurrentGas(true);
        }
        else if (_gasConvertInput < 0){
                print(_gasConvertInput);

            _alchemySystem.convertCurrentGas(false);
        }
        // if (_gasSwitchInput > 0){
        //     _alchemySystem.switchCurrentGas(false);
        // }
        // else if (_gasSwitchInput < 0){
        //     _alchemySystem.switchCurrentGas(false);
        // }
    }

    #region Action Handlers
    public void OnMovement(InputAction.CallbackContext ctx)
    {
        _movementInput = ctx.ReadValue<Vector2>();
    }

    public void OnRefuel(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
            _alchemySystem.upgradeTransaction(TradeType.Refuel);
    }

    public void OnRepair(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
            _alchemySystem.upgradeTransaction(TradeType.Repair);
    }

    public void OnUpgradeDefense(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
            _alchemySystem.upgradeTransaction(TradeType.UpgradeDefense);
    }

    public void OnUpgradeEngine(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
            _alchemySystem.upgradeTransaction(TradeType.UpgradeDefense);
    }

    public void OnConvertGas(InputAction.CallbackContext ctx)
    {
        _gasConvertInput = ctx.ReadValue<float>();
    }

    public void OnSwitchGas(InputAction.CallbackContext ctx)
    {
        if (ctx.performed){
            bool yes = true;
            if (ctx.ReadValue<float>() > 0){
                yes = true;
            }
            else if (ctx.ReadValue<float>() < 0){
                yes = false;
            }

            _alchemySystem.switchCurrentGas(yes);
        }
    }
    #endregion

}
