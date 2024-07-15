//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Inputs/New Inputs.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @NewInputs: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @NewInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""New Inputs"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""3a57b064-4803-4dc9-a87f-b99a7b1060ac"",
            ""actions"": [
                {
                    ""name"": ""Walk"",
                    ""type"": ""Value"",
                    ""id"": ""3212eba8-252e-407a-8a82-070875974b7e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Rotation X"",
                    ""type"": ""Value"",
                    ""id"": ""9d7e6e1e-6883-4c0c-b86c-da9102c23f7c"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Rotation Y"",
                    ""type"": ""Value"",
                    ""id"": ""5fb40d62-140d-45b8-b951-3f1c6eb9cf2d"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Lighter/Flashlight"",
                    ""type"": ""Button"",
                    ""id"": ""df8bcf9d-d685-42b7-b0af-7c9833fe256d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ItemInteractions"",
                    ""type"": ""Button"",
                    ""id"": ""3f7ead75-5447-49b7-89f9-f5fb5672ff10"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Open"",
                    ""type"": ""Button"",
                    ""id"": ""fb014e4e-f8e1-4b17-8c6d-3050c4d6c9cf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""51618eef-3cda-49ad-9dc4-b7d1a53fdba7"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""122a726d-3fca-48e6-be73-8e6988a1b4ad"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""249b8893-0571-4a0e-924c-26d1966fc3e5"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7852bd27-944d-4f1a-85ae-4cca04203b3a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3668d466-ffd1-4b2a-afa4-98fcf1371fae"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""12ad79fd-db72-4a63-9ade-cd6e1ab9ba6c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5b5933d1-3ee4-4e8b-85e4-8252f619ff58"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5a3779ba-397f-4466-b914-c30953ccbde8"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""68d00ca8-6aa6-44a2-a831-013027ed37ca"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ef0793d3-2dc6-4b90-8fdd-5f10b5b93e84"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""4dc73860-727a-4b4b-b1ed-b55de723dec5"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation X"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""28140536-bc2b-481b-8427-a978266d067c"",
                    ""path"": ""<Gamepad>/rightStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation X"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8c2786c5-d518-425a-a902-dc65d05652f0"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation Y"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""31e2dacc-034d-4e49-9b67-e38ec299c110"",
                    ""path"": ""<Gamepad>/rightStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation Y"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9b8e3094-05d4-4e94-9f83-bdce2373aa0b"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lighter/Flashlight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""441f09de-4342-49ad-ab80-54e80d2ddeed"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lighter/Flashlight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cb1a2d69-bcfa-4872-8d18-5af3c52975cf"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ItemInteractions"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""be6c00dc-e1dd-432f-9390-7e8c59fc29e9"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Open"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""9ad4eb2a-e677-44bb-88e2-6c78052dde7b"",
            ""actions"": [
                {
                    ""name"": ""open"",
                    ""type"": ""Button"",
                    ""id"": ""d1200456-73d5-43ec-9c7b-dbc4a1046f48"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Use"",
                    ""type"": ""Button"",
                    ""id"": ""e3a66b4c-2ca5-4355-962d-c36197df33d1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f4dfee9a-b137-4dcc-a091-40c0d93876d1"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""open"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dc61df45-9a7b-4a7c-8150-a9af28f31485"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Use"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Walk = m_Player.FindAction("Walk", throwIfNotFound: true);
        m_Player_RotationX = m_Player.FindAction("Rotation X", throwIfNotFound: true);
        m_Player_RotationY = m_Player.FindAction("Rotation Y", throwIfNotFound: true);
        m_Player_LighterFlashlight = m_Player.FindAction("Lighter/Flashlight", throwIfNotFound: true);
        m_Player_ItemInteractions = m_Player.FindAction("ItemInteractions", throwIfNotFound: true);
        m_Player_Open = m_Player.FindAction("Open", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_open = m_UI.FindAction("open", throwIfNotFound: true);
        m_UI_Use = m_UI.FindAction("Use", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Player
    private readonly InputActionMap m_Player;
    private List<IPlayerActions> m_PlayerActionsCallbackInterfaces = new List<IPlayerActions>();
    private readonly InputAction m_Player_Walk;
    private readonly InputAction m_Player_RotationX;
    private readonly InputAction m_Player_RotationY;
    private readonly InputAction m_Player_LighterFlashlight;
    private readonly InputAction m_Player_ItemInteractions;
    private readonly InputAction m_Player_Open;
    public struct PlayerActions
    {
        private @NewInputs m_Wrapper;
        public PlayerActions(@NewInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Walk => m_Wrapper.m_Player_Walk;
        public InputAction @RotationX => m_Wrapper.m_Player_RotationX;
        public InputAction @RotationY => m_Wrapper.m_Player_RotationY;
        public InputAction @LighterFlashlight => m_Wrapper.m_Player_LighterFlashlight;
        public InputAction @ItemInteractions => m_Wrapper.m_Player_ItemInteractions;
        public InputAction @Open => m_Wrapper.m_Player_Open;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Add(instance);
            @Walk.started += instance.OnWalk;
            @Walk.performed += instance.OnWalk;
            @Walk.canceled += instance.OnWalk;
            @RotationX.started += instance.OnRotationX;
            @RotationX.performed += instance.OnRotationX;
            @RotationX.canceled += instance.OnRotationX;
            @RotationY.started += instance.OnRotationY;
            @RotationY.performed += instance.OnRotationY;
            @RotationY.canceled += instance.OnRotationY;
            @LighterFlashlight.started += instance.OnLighterFlashlight;
            @LighterFlashlight.performed += instance.OnLighterFlashlight;
            @LighterFlashlight.canceled += instance.OnLighterFlashlight;
            @ItemInteractions.started += instance.OnItemInteractions;
            @ItemInteractions.performed += instance.OnItemInteractions;
            @ItemInteractions.canceled += instance.OnItemInteractions;
            @Open.started += instance.OnOpen;
            @Open.performed += instance.OnOpen;
            @Open.canceled += instance.OnOpen;
        }

        private void UnregisterCallbacks(IPlayerActions instance)
        {
            @Walk.started -= instance.OnWalk;
            @Walk.performed -= instance.OnWalk;
            @Walk.canceled -= instance.OnWalk;
            @RotationX.started -= instance.OnRotationX;
            @RotationX.performed -= instance.OnRotationX;
            @RotationX.canceled -= instance.OnRotationX;
            @RotationY.started -= instance.OnRotationY;
            @RotationY.performed -= instance.OnRotationY;
            @RotationY.canceled -= instance.OnRotationY;
            @LighterFlashlight.started -= instance.OnLighterFlashlight;
            @LighterFlashlight.performed -= instance.OnLighterFlashlight;
            @LighterFlashlight.canceled -= instance.OnLighterFlashlight;
            @ItemInteractions.started -= instance.OnItemInteractions;
            @ItemInteractions.performed -= instance.OnItemInteractions;
            @ItemInteractions.canceled -= instance.OnItemInteractions;
            @Open.started -= instance.OnOpen;
            @Open.performed -= instance.OnOpen;
            @Open.canceled -= instance.OnOpen;
        }

        public void RemoveCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private List<IUIActions> m_UIActionsCallbackInterfaces = new List<IUIActions>();
    private readonly InputAction m_UI_open;
    private readonly InputAction m_UI_Use;
    public struct UIActions
    {
        private @NewInputs m_Wrapper;
        public UIActions(@NewInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @open => m_Wrapper.m_UI_open;
        public InputAction @Use => m_Wrapper.m_UI_Use;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void AddCallbacks(IUIActions instance)
        {
            if (instance == null || m_Wrapper.m_UIActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_UIActionsCallbackInterfaces.Add(instance);
            @open.started += instance.OnOpen;
            @open.performed += instance.OnOpen;
            @open.canceled += instance.OnOpen;
            @Use.started += instance.OnUse;
            @Use.performed += instance.OnUse;
            @Use.canceled += instance.OnUse;
        }

        private void UnregisterCallbacks(IUIActions instance)
        {
            @open.started -= instance.OnOpen;
            @open.performed -= instance.OnOpen;
            @open.canceled -= instance.OnOpen;
            @Use.started -= instance.OnUse;
            @Use.performed -= instance.OnUse;
            @Use.canceled -= instance.OnUse;
        }

        public void RemoveCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IUIActions instance)
        {
            foreach (var item in m_Wrapper.m_UIActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_UIActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public UIActions @UI => new UIActions(this);
    public interface IPlayerActions
    {
        void OnWalk(InputAction.CallbackContext context);
        void OnRotationX(InputAction.CallbackContext context);
        void OnRotationY(InputAction.CallbackContext context);
        void OnLighterFlashlight(InputAction.CallbackContext context);
        void OnItemInteractions(InputAction.CallbackContext context);
        void OnOpen(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnOpen(InputAction.CallbackContext context);
        void OnUse(InputAction.CallbackContext context);
    }
}
