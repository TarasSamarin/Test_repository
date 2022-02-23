// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/NewInputSystem/InputController.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputController : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputController"",
    ""maps"": [
        {
            ""name"": ""PlayerControll"",
            ""id"": ""3cb46dc2-6a77-40f0-8985-2e1e66567d48"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""3ec5168a-c8bf-4b29-bd50-7269ff0eb39a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Atack"",
                    ""type"": ""Button"",
                    ""id"": ""81401133-8e74-404a-b51e-f0eac270181e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeWeaponNext"",
                    ""type"": ""Button"",
                    ""id"": ""61e2cf9c-7888-4b06-9e62-d2f454a64019"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeWeaponPrevious"",
                    ""type"": ""Button"",
                    ""id"": ""acc3633d-54f4-4a78-92ab-272e166491d2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""adf117ee-663a-46fc-b471-e72cd502f414"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f84fe956-d8f4-40f9-a7d8-c61f4b7473d8"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d50aea67-74ec-43b6-9a11-ae990549ab23"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8f76eb0f-936f-40d0-bd18-d6b6e704ab7e"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8b2d1364-0a05-4b01-a81b-daa653a18dbd"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0bcfb419-4cfe-4256-914e-78564087049f"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Atack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""521d3f0a-0ef9-4617-a3a4-1a0f1b1295d9"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ChangeWeaponNext"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""710324c4-793d-4cdc-9075-97ca6b65d1b3"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ChangeWeaponPrevious"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // PlayerControll
        m_PlayerControll = asset.FindActionMap("PlayerControll", throwIfNotFound: true);
        m_PlayerControll_Move = m_PlayerControll.FindAction("Move", throwIfNotFound: true);
        m_PlayerControll_Atack = m_PlayerControll.FindAction("Atack", throwIfNotFound: true);
        m_PlayerControll_ChangeWeaponNext = m_PlayerControll.FindAction("ChangeWeaponNext", throwIfNotFound: true);
        m_PlayerControll_ChangeWeaponPrevious = m_PlayerControll.FindAction("ChangeWeaponPrevious", throwIfNotFound: true);
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

    // PlayerControll
    private readonly InputActionMap m_PlayerControll;
    private IPlayerControllActions m_PlayerControllActionsCallbackInterface;
    private readonly InputAction m_PlayerControll_Move;
    private readonly InputAction m_PlayerControll_Atack;
    private readonly InputAction m_PlayerControll_ChangeWeaponNext;
    private readonly InputAction m_PlayerControll_ChangeWeaponPrevious;
    public struct PlayerControllActions
    {
        private @InputController m_Wrapper;
        public PlayerControllActions(@InputController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerControll_Move;
        public InputAction @Atack => m_Wrapper.m_PlayerControll_Atack;
        public InputAction @ChangeWeaponNext => m_Wrapper.m_PlayerControll_ChangeWeaponNext;
        public InputAction @ChangeWeaponPrevious => m_Wrapper.m_PlayerControll_ChangeWeaponPrevious;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControll; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControllActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControllActions instance)
        {
            if (m_Wrapper.m_PlayerControllActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerControllActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerControllActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerControllActionsCallbackInterface.OnMove;
                @Atack.started -= m_Wrapper.m_PlayerControllActionsCallbackInterface.OnAtack;
                @Atack.performed -= m_Wrapper.m_PlayerControllActionsCallbackInterface.OnAtack;
                @Atack.canceled -= m_Wrapper.m_PlayerControllActionsCallbackInterface.OnAtack;
                @ChangeWeaponNext.started -= m_Wrapper.m_PlayerControllActionsCallbackInterface.OnChangeWeaponNext;
                @ChangeWeaponNext.performed -= m_Wrapper.m_PlayerControllActionsCallbackInterface.OnChangeWeaponNext;
                @ChangeWeaponNext.canceled -= m_Wrapper.m_PlayerControllActionsCallbackInterface.OnChangeWeaponNext;
                @ChangeWeaponPrevious.started -= m_Wrapper.m_PlayerControllActionsCallbackInterface.OnChangeWeaponPrevious;
                @ChangeWeaponPrevious.performed -= m_Wrapper.m_PlayerControllActionsCallbackInterface.OnChangeWeaponPrevious;
                @ChangeWeaponPrevious.canceled -= m_Wrapper.m_PlayerControllActionsCallbackInterface.OnChangeWeaponPrevious;
            }
            m_Wrapper.m_PlayerControllActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Atack.started += instance.OnAtack;
                @Atack.performed += instance.OnAtack;
                @Atack.canceled += instance.OnAtack;
                @ChangeWeaponNext.started += instance.OnChangeWeaponNext;
                @ChangeWeaponNext.performed += instance.OnChangeWeaponNext;
                @ChangeWeaponNext.canceled += instance.OnChangeWeaponNext;
                @ChangeWeaponPrevious.started += instance.OnChangeWeaponPrevious;
                @ChangeWeaponPrevious.performed += instance.OnChangeWeaponPrevious;
                @ChangeWeaponPrevious.canceled += instance.OnChangeWeaponPrevious;
            }
        }
    }
    public PlayerControllActions @PlayerControll => new PlayerControllActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IPlayerControllActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnAtack(InputAction.CallbackContext context);
        void OnChangeWeaponNext(InputAction.CallbackContext context);
        void OnChangeWeaponPrevious(InputAction.CallbackContext context);
    }
}
