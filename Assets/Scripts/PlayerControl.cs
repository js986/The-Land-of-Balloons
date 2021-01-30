using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    MasterControls input;

    Vector2 _movementInput;

    [SerializeField] Vector2 _movementSpeedScale = new Vector2(1,1);
    Rigidbody2D _rb;

    void Awake()
    {
        input = new MasterControls();
    }

    void Start(){
        _rb = GetComponent<Rigidbody2D>();
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
        transform.Translate(
            _movementInput.x * _movementSpeedScale.x, 
            _movementInput.y * _movementSpeedScale.y, 
            0);
    }

    #region Action Handlers
    void OnHorizontalMovement(InputAction.CallbackContext ctx){

        _movementInput.x = ctx.ReadValue<float>();
    }

    void OnVerticalMovement(InputAction.CallbackContext ctx){
        _movementInput.y = ctx.ReadValue<float>();
        _rb.isKinematic = true;
        _rb.velocity = Vector2.zero;
    }

    void OffVerticalMovement(InputAction.CallbackContext ctx){
        _movementInput.y = 0;
        _rb.isKinematic = false;
    }
    #endregion

}
