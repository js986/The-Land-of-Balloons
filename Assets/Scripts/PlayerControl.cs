using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    MasterControls input;

    Vector2 _movementInput;

    float vertical_boost;
    float horizontal_boost;

    [SerializeField] Vector2 _movementSpeedScale = new Vector2(1,1);
    [SerializeField] Sprite[] sprites = new Sprite[5];
    SpriteRenderer _sr;
    Rigidbody2D _rb;

    void Awake()
    {
        input = new MasterControls();
    }

    void Start(){
        _rb = GetComponent<Rigidbody2D>();
        _sr = GetComponent<SpriteRenderer>();
        _sr.sprite = sprites[0];
    }
    private void OnEnable(){

        input.Enable();
        input.Main.Horizontal.performed += OnHorizontalMovement;
        input.Main.Horizontal.canceled += OnHorizontalMovement;
        input.Main.Vertical.performed += OnVerticalMovement;
        input.Main.Vertical.canceled += OffVerticalMovement;
    }

    private void OnDisable(){

        input.Main.Horizontal.performed -= OnHorizontalMovement;
        input.Main.Horizontal.canceled -= OnHorizontalMovement;
        input.Main.Vertical.performed -= OnVerticalMovement;
        input.Main.Vertical.canceled -= OffVerticalMovement;
        input.Disable();
    }

    void FixedUpdate(){
        vertical_boost = PickupManager.instance.blue_counter/100;
        horizontal_boost = PickupManager.instance.green_counter/100;
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
            _movementInput.x * (horizontal_boost + _movementSpeedScale.x), 
            _movementInput.y * (vertical_boost + _movementSpeedScale.y), 
            0
        );

        if (_movementInput.y > 0)
            _rb.velocity = Vector2.zero;
    
    }

    #region Action Handlers
    void OnHorizontalMovement(InputAction.CallbackContext ctx){

        _movementInput.x = ctx.ReadValue<float>();
    }

    void OnVerticalMovement(InputAction.CallbackContext ctx){
        _movementInput.y = ctx.ReadValue<float>();
    }

    void OffVerticalMovement(InputAction.CallbackContext ctx){
        _movementInput.y = 0;
    }
    #endregion

}
