// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Input/MasterControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MasterControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MasterControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MasterControls"",
    ""maps"": [
        {
            ""name"": ""Main"",
            ""id"": ""da1bca85-922f-495d-a8b2-efae300a2d59"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""3466b0c7-da75-428b-b86a-40146dd757ff"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Refuel"",
                    ""type"": ""PassThrough"",
                    ""id"": ""addd715d-b422-4d7f-8fdb-f15f0f883867"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Repair"",
                    ""type"": ""Button"",
                    ""id"": ""d22e37d7-6411-4d4e-917e-b5d9c8c236b5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UpgradeDefense"",
                    ""type"": ""Button"",
                    ""id"": ""df18247b-4387-4ab3-b6d1-0d270dbf60ae"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UpgradeEngine"",
                    ""type"": ""Button"",
                    ""id"": ""e2f83f50-24fb-4a28-8e4b-4a00289648fa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ConvertGas"",
                    ""type"": ""Button"",
                    ""id"": ""c0672b5f-f197-441e-bb6e-ac657110ccd3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwitchGas"",
                    ""type"": ""Button"",
                    ""id"": ""21c2a442-9a96-4d33-b12c-22b2f0e2a5be"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""a6174b27-da6e-4cf5-b9d7-4de11be00d4b"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""be642f64-7a40-447c-b134-423253ec8f89"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b40604af-c4c4-45c1-aa0d-ecbdc7cd6cdc"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""79eb8f4e-819e-4e8d-be22-a3240d9c2c6e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""984a1baa-8169-48a8-890e-2e2317929a62"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""8dcd3b20-70b0-4d05-8d6b-ee0ba5945bd0"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""58b56faf-b7dd-4f0f-986f-efd286a132e4"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""98c6be90-2eb7-47a5-bf4b-fcc23f7def66"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a0db6c9a-efaf-4b99-a779-1b27972b9946"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4b4963c1-9b7f-48ae-9ad0-84ab578d80b2"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""69085e86-2243-4f57-8dfb-81eddadb4b30"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Refuel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""75ad1333-61bf-4774-ba16-9dae81364117"",
                    ""path"": ""<Keyboard>/u"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Refuel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d6f7fbe2-9116-49a1-b930-95e01b711197"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Repair"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f15ab6f5-8f8a-4fa0-bafd-cc5d7aa79d55"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Repair"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""de9debce-19b1-4122-99e0-5cc5b7871d77"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpgradeDefense"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fbd46fed-c34d-4654-8069-1f2f4261a776"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpgradeDefense"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2f4af7fa-342e-4c84-b4ab-a93ce91c3621"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpgradeEngine"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5d446eaa-5764-433a-9c8e-1abfdd4b7fbd"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpgradeEngine"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""fb036aef-99a4-4cf4-b26e-d3389d1829bd"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ConvertGas"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""7332771a-4a20-485c-806f-77f8f5d50e2c"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ConvertGas"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""986510d3-7f9b-48f4-9201-fb6c28ea0f11"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ConvertGas"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""7093c4cf-bb7c-4d08-9ce3-5a4591d86dac"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchGas"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""8620d082-8f09-461e-8056-0f769b252683"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchGas"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""c19e5fc7-687e-481e-ba92-c01bfefd9787"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchGas"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Main
        m_Main = asset.FindActionMap("Main", throwIfNotFound: true);
        m_Main_Movement = m_Main.FindAction("Movement", throwIfNotFound: true);
        m_Main_Refuel = m_Main.FindAction("Refuel", throwIfNotFound: true);
        m_Main_Repair = m_Main.FindAction("Repair", throwIfNotFound: true);
        m_Main_UpgradeDefense = m_Main.FindAction("UpgradeDefense", throwIfNotFound: true);
        m_Main_UpgradeEngine = m_Main.FindAction("UpgradeEngine", throwIfNotFound: true);
        m_Main_ConvertGas = m_Main.FindAction("ConvertGas", throwIfNotFound: true);
        m_Main_SwitchGas = m_Main.FindAction("SwitchGas", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Main
    private readonly InputActionMap m_Main;
    private IMainActions m_MainActionsCallbackInterface;
    private readonly InputAction m_Main_Movement;
    private readonly InputAction m_Main_Refuel;
    private readonly InputAction m_Main_Repair;
    private readonly InputAction m_Main_UpgradeDefense;
    private readonly InputAction m_Main_UpgradeEngine;
    private readonly InputAction m_Main_ConvertGas;
    private readonly InputAction m_Main_SwitchGas;
    public struct MainActions
    {
        private @MasterControls m_Wrapper;
        public MainActions(@MasterControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Main_Movement;
        public InputAction @Refuel => m_Wrapper.m_Main_Refuel;
        public InputAction @Repair => m_Wrapper.m_Main_Repair;
        public InputAction @UpgradeDefense => m_Wrapper.m_Main_UpgradeDefense;
        public InputAction @UpgradeEngine => m_Wrapper.m_Main_UpgradeEngine;
        public InputAction @ConvertGas => m_Wrapper.m_Main_ConvertGas;
        public InputAction @SwitchGas => m_Wrapper.m_Main_SwitchGas;
        public InputActionMap Get() { return m_Wrapper.m_Main; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MainActions set) { return set.Get(); }
        public void SetCallbacks(IMainActions instance)
        {
            if (m_Wrapper.m_MainActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_MainActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnMovement;
                @Refuel.started -= m_Wrapper.m_MainActionsCallbackInterface.OnRefuel;
                @Refuel.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnRefuel;
                @Refuel.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnRefuel;
                @Repair.started -= m_Wrapper.m_MainActionsCallbackInterface.OnRepair;
                @Repair.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnRepair;
                @Repair.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnRepair;
                @UpgradeDefense.started -= m_Wrapper.m_MainActionsCallbackInterface.OnUpgradeDefense;
                @UpgradeDefense.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnUpgradeDefense;
                @UpgradeDefense.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnUpgradeDefense;
                @UpgradeEngine.started -= m_Wrapper.m_MainActionsCallbackInterface.OnUpgradeEngine;
                @UpgradeEngine.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnUpgradeEngine;
                @UpgradeEngine.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnUpgradeEngine;
                @ConvertGas.started -= m_Wrapper.m_MainActionsCallbackInterface.OnConvertGas;
                @ConvertGas.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnConvertGas;
                @ConvertGas.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnConvertGas;
                @SwitchGas.started -= m_Wrapper.m_MainActionsCallbackInterface.OnSwitchGas;
                @SwitchGas.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnSwitchGas;
                @SwitchGas.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnSwitchGas;
            }
            m_Wrapper.m_MainActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Refuel.started += instance.OnRefuel;
                @Refuel.performed += instance.OnRefuel;
                @Refuel.canceled += instance.OnRefuel;
                @Repair.started += instance.OnRepair;
                @Repair.performed += instance.OnRepair;
                @Repair.canceled += instance.OnRepair;
                @UpgradeDefense.started += instance.OnUpgradeDefense;
                @UpgradeDefense.performed += instance.OnUpgradeDefense;
                @UpgradeDefense.canceled += instance.OnUpgradeDefense;
                @UpgradeEngine.started += instance.OnUpgradeEngine;
                @UpgradeEngine.performed += instance.OnUpgradeEngine;
                @UpgradeEngine.canceled += instance.OnUpgradeEngine;
                @ConvertGas.started += instance.OnConvertGas;
                @ConvertGas.performed += instance.OnConvertGas;
                @ConvertGas.canceled += instance.OnConvertGas;
                @SwitchGas.started += instance.OnSwitchGas;
                @SwitchGas.performed += instance.OnSwitchGas;
                @SwitchGas.canceled += instance.OnSwitchGas;
            }
        }
    }
    public MainActions @Main => new MainActions(this);
    public interface IMainActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnRefuel(InputAction.CallbackContext context);
        void OnRepair(InputAction.CallbackContext context);
        void OnUpgradeDefense(InputAction.CallbackContext context);
        void OnUpgradeEngine(InputAction.CallbackContext context);
        void OnConvertGas(InputAction.CallbackContext context);
        void OnSwitchGas(InputAction.CallbackContext context);
    }
}
