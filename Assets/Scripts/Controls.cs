// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""20a72843-e0c8-45b6-abe6-1fd73e2928aa"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""e596b882-3434-461f-94ad-3ed40713433c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""685af4cd-5782-4ab0-857b-a1ecdc285fad"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Circle"",
                    ""type"": ""Button"",
                    ""id"": ""62e62d9f-f2c2-4917-bc10-fb0073888c94"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Triangle"",
                    ""type"": ""Button"",
                    ""id"": ""1d5ee825-5b18-4745-858e-9e8c8af72b45"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Square"",
                    ""type"": ""Button"",
                    ""id"": ""b965e388-1dcf-492c-bce9-694ca3ff8675"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""R1"",
                    ""type"": ""Button"",
                    ""id"": ""f45bb8df-0730-4302-b27a-f32995d59d8a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""R2"",
                    ""type"": ""Button"",
                    ""id"": ""4f48be15-a229-41c5-b89d-e27a16e28b08"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""L1"",
                    ""type"": ""Button"",
                    ""id"": ""cabed857-41a6-4ea8-82d6-74f3164f548f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""L2"",
                    ""type"": ""Button"",
                    ""id"": ""1652f10d-1dcc-4395-99f6-93fe00d94347"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Options"",
                    ""type"": ""Button"",
                    ""id"": ""23121259-a832-4b61-afcb-eec1a615df60"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3549be18-255c-4be7-9bc7-c67dfca89a6d"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""bbbf8940-75a1-44ce-a01e-e70e66225abb"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f4f80eed-87e3-433d-ac4b-bd32f550ec12"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""7b029738-5e63-40f4-8d47-01f8b1de2ea3"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a6f8328f-cc36-4437-86e1-111445e5e62d"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""51301c69-46a4-49ad-bc5c-5417c0107c49"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Circle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7ab18983-324e-4ca9-94c6-5e59c216f024"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Triangle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bb4a3407-6476-4f33-b333-6ba481d07a40"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Square"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""21611d73-e349-488d-a172-47d5b674e01f"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""R1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cd05b87f-c5a3-4191-a519-1fe07ea9ebeb"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""R2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c617c68c-1b58-4e3d-bf3f-f27fdc552509"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""L1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7b96986b-df7f-4b5c-9a6b-0b7acd4964d8"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""L2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c71f299a-0382-4f78-9407-99d7e2085e6a"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Options"",
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
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_Circle = m_Player.FindAction("Circle", throwIfNotFound: true);
        m_Player_Triangle = m_Player.FindAction("Triangle", throwIfNotFound: true);
        m_Player_Square = m_Player.FindAction("Square", throwIfNotFound: true);
        m_Player_R1 = m_Player.FindAction("R1", throwIfNotFound: true);
        m_Player_R2 = m_Player.FindAction("R2", throwIfNotFound: true);
        m_Player_L1 = m_Player.FindAction("L1", throwIfNotFound: true);
        m_Player_L2 = m_Player.FindAction("L2", throwIfNotFound: true);
        m_Player_Options = m_Player.FindAction("Options", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_Circle;
    private readonly InputAction m_Player_Triangle;
    private readonly InputAction m_Player_Square;
    private readonly InputAction m_Player_R1;
    private readonly InputAction m_Player_R2;
    private readonly InputAction m_Player_L1;
    private readonly InputAction m_Player_L2;
    private readonly InputAction m_Player_Options;
    public struct PlayerActions
    {
        private @Controls m_Wrapper;
        public PlayerActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @Circle => m_Wrapper.m_Player_Circle;
        public InputAction @Triangle => m_Wrapper.m_Player_Triangle;
        public InputAction @Square => m_Wrapper.m_Player_Square;
        public InputAction @R1 => m_Wrapper.m_Player_R1;
        public InputAction @R2 => m_Wrapper.m_Player_R2;
        public InputAction @L1 => m_Wrapper.m_Player_L1;
        public InputAction @L2 => m_Wrapper.m_Player_L2;
        public InputAction @Options => m_Wrapper.m_Player_Options;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Circle.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCircle;
                @Circle.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCircle;
                @Circle.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCircle;
                @Triangle.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTriangle;
                @Triangle.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTriangle;
                @Triangle.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTriangle;
                @Square.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSquare;
                @Square.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSquare;
                @Square.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSquare;
                @R1.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnR1;
                @R1.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnR1;
                @R1.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnR1;
                @R2.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnR2;
                @R2.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnR2;
                @R2.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnR2;
                @L1.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnL1;
                @L1.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnL1;
                @L1.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnL1;
                @L2.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnL2;
                @L2.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnL2;
                @L2.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnL2;
                @Options.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnOptions;
                @Options.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnOptions;
                @Options.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnOptions;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Circle.started += instance.OnCircle;
                @Circle.performed += instance.OnCircle;
                @Circle.canceled += instance.OnCircle;
                @Triangle.started += instance.OnTriangle;
                @Triangle.performed += instance.OnTriangle;
                @Triangle.canceled += instance.OnTriangle;
                @Square.started += instance.OnSquare;
                @Square.performed += instance.OnSquare;
                @Square.canceled += instance.OnSquare;
                @R1.started += instance.OnR1;
                @R1.performed += instance.OnR1;
                @R1.canceled += instance.OnR1;
                @R2.started += instance.OnR2;
                @R2.performed += instance.OnR2;
                @R2.canceled += instance.OnR2;
                @L1.started += instance.OnL1;
                @L1.performed += instance.OnL1;
                @L1.canceled += instance.OnL1;
                @L2.started += instance.OnL2;
                @L2.performed += instance.OnL2;
                @L2.canceled += instance.OnL2;
                @Options.started += instance.OnOptions;
                @Options.performed += instance.OnOptions;
                @Options.canceled += instance.OnOptions;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnCircle(InputAction.CallbackContext context);
        void OnTriangle(InputAction.CallbackContext context);
        void OnSquare(InputAction.CallbackContext context);
        void OnR1(InputAction.CallbackContext context);
        void OnR2(InputAction.CallbackContext context);
        void OnL1(InputAction.CallbackContext context);
        void OnL2(InputAction.CallbackContext context);
        void OnOptions(InputAction.CallbackContext context);
    }
}
