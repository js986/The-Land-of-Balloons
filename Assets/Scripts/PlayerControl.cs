using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    MasterControls input;
    float _horizontalInput;
    float _verticalInput;
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
        transform.Translate(_horizontalInput, _verticalInput, 0);
    }

    #region Action Handlers
    void OnHorizontalMovement(InputAction.CallbackContext ctx){

        _horizontalInput = ctx.ReadValue<float>();
    }

    void OnVerticalMovement(InputAction.CallbackContext ctx){
        _verticalInput = ctx.ReadValue<float>();
        _rb.isKinematic = true;
        _rb.velocity = Vector2.zero;
    }

    void OffVerticalMovement(InputAction.CallbackContext ctx){
        _verticalInput = 0;
        _rb.isKinematic = false;
    }
    #endregion

}
