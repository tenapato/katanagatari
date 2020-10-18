// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/CharacterSelectionScripts/CursorControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @CursorControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @CursorControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CursorControls"",
    ""maps"": [
        {
            ""name"": ""Cursor"",
            ""id"": ""deecde1a-028a-4f2d-abcf-8609eae970aa"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""fdf41219-f0bc-4ed6-8acc-5739aeba6a8f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveUPDOWN"",
                    ""type"": ""Button"",
                    ""id"": ""d79911b8-a29a-4b5a-88ad-d8908f554813"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Circle"",
                    ""type"": ""Button"",
                    ""id"": ""89c1e3cc-4ef2-4b98-8c08-5d787738463d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cross"",
                    ""type"": ""Button"",
                    ""id"": ""eecf7ab0-3425-491a-ae8a-a49d9c5e4972"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Horizontal"",
                    ""id"": ""0161c0be-ed76-4dc7-8823-973b2883ab2d"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""ec4b3ec9-bc7c-4f77-930f-7ca665c29613"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""604265e0-9f8d-4804-be33-bdb205071908"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""dee7b9b9-60bc-449c-8f12-af5f0a38972b"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveUPDOWN"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""fc4b71dc-2114-4c34-9f44-71ce6d2c2734"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveUPDOWN"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e8e61ef6-94e9-4b74-9497-5ccc338ba526"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveUPDOWN"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d1c792c5-93e5-42ae-b2df-a43512251615"",
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
                    ""id"": ""c8640549-8f37-4004-84fa-df14c4cbdec1"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cross"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": []
        }
    ]
}");
        // Cursor
        m_Cursor = asset.FindActionMap("Cursor", throwIfNotFound: true);
        m_Cursor_Move = m_Cursor.FindAction("Move", throwIfNotFound: true);
        m_Cursor_MoveUPDOWN = m_Cursor.FindAction("MoveUPDOWN", throwIfNotFound: true);
        m_Cursor_Circle = m_Cursor.FindAction("Circle", throwIfNotFound: true);
        m_Cursor_Cross = m_Cursor.FindAction("Cross", throwIfNotFound: true);
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

    // Cursor
    private readonly InputActionMap m_Cursor;
    private ICursorActions m_CursorActionsCallbackInterface;
    private readonly InputAction m_Cursor_Move;
    private readonly InputAction m_Cursor_MoveUPDOWN;
    private readonly InputAction m_Cursor_Circle;
    private readonly InputAction m_Cursor_Cross;
    public struct CursorActions
    {
        private @CursorControls m_Wrapper;
        public CursorActions(@CursorControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Cursor_Move;
        public InputAction @MoveUPDOWN => m_Wrapper.m_Cursor_MoveUPDOWN;
        public InputAction @Circle => m_Wrapper.m_Cursor_Circle;
        public InputAction @Cross => m_Wrapper.m_Cursor_Cross;
        public InputActionMap Get() { return m_Wrapper.m_Cursor; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CursorActions set) { return set.Get(); }
        public void SetCallbacks(ICursorActions instance)
        {
            if (m_Wrapper.m_CursorActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_CursorActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_CursorActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_CursorActionsCallbackInterface.OnMove;
                @MoveUPDOWN.started -= m_Wrapper.m_CursorActionsCallbackInterface.OnMoveUPDOWN;
                @MoveUPDOWN.performed -= m_Wrapper.m_CursorActionsCallbackInterface.OnMoveUPDOWN;
                @MoveUPDOWN.canceled -= m_Wrapper.m_CursorActionsCallbackInterface.OnMoveUPDOWN;
                @Circle.started -= m_Wrapper.m_CursorActionsCallbackInterface.OnCircle;
                @Circle.performed -= m_Wrapper.m_CursorActionsCallbackInterface.OnCircle;
                @Circle.canceled -= m_Wrapper.m_CursorActionsCallbackInterface.OnCircle;
                @Cross.started -= m_Wrapper.m_CursorActionsCallbackInterface.OnCross;
                @Cross.performed -= m_Wrapper.m_CursorActionsCallbackInterface.OnCross;
                @Cross.canceled -= m_Wrapper.m_CursorActionsCallbackInterface.OnCross;
            }
            m_Wrapper.m_CursorActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @MoveUPDOWN.started += instance.OnMoveUPDOWN;
                @MoveUPDOWN.performed += instance.OnMoveUPDOWN;
                @MoveUPDOWN.canceled += instance.OnMoveUPDOWN;
                @Circle.started += instance.OnCircle;
                @Circle.performed += instance.OnCircle;
                @Circle.canceled += instance.OnCircle;
                @Cross.started += instance.OnCross;
                @Cross.performed += instance.OnCross;
                @Cross.canceled += instance.OnCross;
            }
        }
    }
    public CursorActions @Cursor => new CursorActions(this);
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface ICursorActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnMoveUPDOWN(InputAction.CallbackContext context);
        void OnCircle(InputAction.CallbackContext context);
        void OnCross(InputAction.CallbackContext context);
    }
}
