//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/ExplosiveLLC/RPG Character Mecanim Animation Pack FREE/Inputs/RPGInputActions.inputactions
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

namespace RPGCharacterAnims
{
    public partial class @RPGInputs: IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @RPGInputs()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""RPGInputActions"",
    ""maps"": [
        {
            ""name"": ""RPGCharacter"",
            ""id"": ""3ead366c-a6b7-44d2-8381-0a0b951f5df8"",
            ""actions"": [
                {
                    ""name"": ""AttackL"",
                    ""type"": ""Button"",
                    ""id"": ""12f351ba-2710-419f-bda3-bf2abf737ff4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""AttackR"",
                    ""type"": ""Button"",
                    ""id"": ""01a71673-bab7-492e-8129-87f3109d7a58"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Knockdown"",
                    ""type"": ""Button"",
                    ""id"": ""8fbfea2e-d59e-48dc-ae84-73e9c0d479f6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Face"",
                    ""type"": ""Button"",
                    ""id"": ""787a80ae-a794-4ad0-8aad-2e110194e427"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Facing"",
                    ""type"": ""Value"",
                    ""id"": ""dd5a4ce2-a4d1-4d8a-bee7-3759c067ffd6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""5679467b-966e-49db-b5a9-aa9e28fc90d2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LightHit"",
                    ""type"": ""Button"",
                    ""id"": ""c6381ffb-3d89-4857-b599-53b47c05849c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""43308ce0-cc64-42b2-a9dd-3295b6ef9f15"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Roll"",
                    ""type"": ""Button"",
                    ""id"": ""9b8a647f-12ad-455b-bc4e-d14bc34f084e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Button"",
                    ""id"": ""aafb5408-6a4f-4fd7-a596-caf6387fc87e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""WeaponDown"",
                    ""type"": ""Button"",
                    ""id"": ""ebe77173-3d6b-449e-9552-b29a4d28a382"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""WeaponUp"",
                    ""type"": ""Button"",
                    ""id"": ""ae0d5111-b008-4443-8ac0-8b971ad35b20"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""2d134bbc-a7cc-4926-9713-da52847052a7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""bbdbdafb-66ad-4206-9f76-c60d53269a1b"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone(min=0.2,max=0.925)"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""2e85cef7-c1cb-4b22-8597-350bec0aa14d"",
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
                    ""id"": ""2120b965-d816-4b44-838a-869511df56c4"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""826155c0-f5d3-45d0-a964-1cd39e4de24d"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""57c3d98e-ba54-40a2-87d3-9640624cf46d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ded9887c-d549-4d24-8f18-e42ff97d6611"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""3a2bc915-4b04-443e-b134-8620b71cf761"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""WeaponUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cff3abbd-e163-4163-8ebb-7e52d1508789"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""da68dbb3-b1e4-446a-97bc-e0cc755186a6"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""49d9ee54-833f-4704-9579-a66ccde8c535"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""AttackL"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f0acae91-204f-447c-9ff5-24d26ff3cee5"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""AttackR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""63104a7a-9566-435a-be44-cab8f87e4ab2"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Face"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""444d5689-a373-4ff8-bc62-5a0435ff4833"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""InvertVector2(invertX=false),StickDeadzone(min=0.125,max=0.925)"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Facing"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a9417228-53a0-4d27-8d6d-d45b933fcd4e"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Knockdown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f11c46ab-cc0b-4bff-8583-9afa124803f9"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0e97cf5e-f636-4a8f-a9e5-e9ab48dbcc74"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb2ae42d-7bed-49d3-ada1-dbaffc27b8db"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""LightHit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2c1b111f-b14e-4638-95be-9154e3b9b55e"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Mouse and Keyboard"",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""19863b85-850a-4781-b0d8-846d0261c5e1"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""WeaponDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""35738ae7-2613-45a2-b3ac-67bd0b14894a"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerInput"",
            ""id"": ""d9a850f1-b5e6-4408-b6f4-b9036ef69461"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""b51161a9-f0b2-4ab8-b2a1-4048da48feca"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""e0ab46c0-e85b-482d-9a38-cd56d1075739"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""c56b9b40-a647-4ca1-856d-bd543580d534"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""b92054d6-945a-4dee-b80c-866485a5e6e1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b7b8f26a-d695-4257-984a-f16c083e82d7"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""057b5230-3bf8-46e7-91cb-b69fd1c428e9"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""128d1d87-aa11-4c05-9894-e4a5b08a821c"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone(min=0.2,max=0.925)"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""6e074f64-4561-4a17-b350-7786fd8150c0"",
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
                    ""id"": ""cea4d29b-4cc1-42c0-84af-7b26660863db"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ec4100e7-93d3-49db-a789-b76868bf9fc6"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""1482210d-f3b8-4a3e-ba4c-8cc211f495a4"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""90d2bb30-e333-4616-8f74-812a797d1c06"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8e7bbd63-0bae-4066-8577-4e197366569a"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6ba25e31-5acd-4e3f-b224-fd58ddebcf4e"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""291db7b2-4461-412d-900a-1d02ad54866b"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Attack"",
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
        },
        {
            ""name"": ""Mouse and Keyboard"",
            ""bindingGroup"": ""Mouse and Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // RPGCharacter
            m_RPGCharacter = asset.FindActionMap("RPGCharacter", throwIfNotFound: true);
            m_RPGCharacter_AttackL = m_RPGCharacter.FindAction("AttackL", throwIfNotFound: true);
            m_RPGCharacter_AttackR = m_RPGCharacter.FindAction("AttackR", throwIfNotFound: true);
            m_RPGCharacter_Knockdown = m_RPGCharacter.FindAction("Knockdown", throwIfNotFound: true);
            m_RPGCharacter_Face = m_RPGCharacter.FindAction("Face", throwIfNotFound: true);
            m_RPGCharacter_Facing = m_RPGCharacter.FindAction("Facing", throwIfNotFound: true);
            m_RPGCharacter_Jump = m_RPGCharacter.FindAction("Jump", throwIfNotFound: true);
            m_RPGCharacter_LightHit = m_RPGCharacter.FindAction("LightHit", throwIfNotFound: true);
            m_RPGCharacter_Move = m_RPGCharacter.FindAction("Move", throwIfNotFound: true);
            m_RPGCharacter_Roll = m_RPGCharacter.FindAction("Roll", throwIfNotFound: true);
            m_RPGCharacter_Aim = m_RPGCharacter.FindAction("Aim", throwIfNotFound: true);
            m_RPGCharacter_WeaponDown = m_RPGCharacter.FindAction("WeaponDown", throwIfNotFound: true);
            m_RPGCharacter_WeaponUp = m_RPGCharacter.FindAction("WeaponUp", throwIfNotFound: true);
            m_RPGCharacter_Sprint = m_RPGCharacter.FindAction("Sprint", throwIfNotFound: true);
            // PlayerInput
            m_PlayerInput = asset.FindActionMap("PlayerInput", throwIfNotFound: true);
            m_PlayerInput_Jump = m_PlayerInput.FindAction("Jump", throwIfNotFound: true);
            m_PlayerInput_Move = m_PlayerInput.FindAction("Move", throwIfNotFound: true);
            m_PlayerInput_Sprint = m_PlayerInput.FindAction("Sprint", throwIfNotFound: true);
            m_PlayerInput_Attack = m_PlayerInput.FindAction("Attack", throwIfNotFound: true);
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

        // RPGCharacter
        private readonly InputActionMap m_RPGCharacter;
        private List<IRPGCharacterActions> m_RPGCharacterActionsCallbackInterfaces = new List<IRPGCharacterActions>();
        private readonly InputAction m_RPGCharacter_AttackL;
        private readonly InputAction m_RPGCharacter_AttackR;
        private readonly InputAction m_RPGCharacter_Knockdown;
        private readonly InputAction m_RPGCharacter_Face;
        private readonly InputAction m_RPGCharacter_Facing;
        private readonly InputAction m_RPGCharacter_Jump;
        private readonly InputAction m_RPGCharacter_LightHit;
        private readonly InputAction m_RPGCharacter_Move;
        private readonly InputAction m_RPGCharacter_Roll;
        private readonly InputAction m_RPGCharacter_Aim;
        private readonly InputAction m_RPGCharacter_WeaponDown;
        private readonly InputAction m_RPGCharacter_WeaponUp;
        private readonly InputAction m_RPGCharacter_Sprint;
        public struct RPGCharacterActions
        {
            private @RPGInputs m_Wrapper;
            public RPGCharacterActions(@RPGInputs wrapper) { m_Wrapper = wrapper; }
            public InputAction @AttackL => m_Wrapper.m_RPGCharacter_AttackL;
            public InputAction @AttackR => m_Wrapper.m_RPGCharacter_AttackR;
            public InputAction @Knockdown => m_Wrapper.m_RPGCharacter_Knockdown;
            public InputAction @Face => m_Wrapper.m_RPGCharacter_Face;
            public InputAction @Facing => m_Wrapper.m_RPGCharacter_Facing;
            public InputAction @Jump => m_Wrapper.m_RPGCharacter_Jump;
            public InputAction @LightHit => m_Wrapper.m_RPGCharacter_LightHit;
            public InputAction @Move => m_Wrapper.m_RPGCharacter_Move;
            public InputAction @Roll => m_Wrapper.m_RPGCharacter_Roll;
            public InputAction @Aim => m_Wrapper.m_RPGCharacter_Aim;
            public InputAction @WeaponDown => m_Wrapper.m_RPGCharacter_WeaponDown;
            public InputAction @WeaponUp => m_Wrapper.m_RPGCharacter_WeaponUp;
            public InputAction @Sprint => m_Wrapper.m_RPGCharacter_Sprint;
            public InputActionMap Get() { return m_Wrapper.m_RPGCharacter; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(RPGCharacterActions set) { return set.Get(); }
            public void AddCallbacks(IRPGCharacterActions instance)
            {
                if (instance == null || m_Wrapper.m_RPGCharacterActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_RPGCharacterActionsCallbackInterfaces.Add(instance);
                @AttackL.started += instance.OnAttackL;
                @AttackL.performed += instance.OnAttackL;
                @AttackL.canceled += instance.OnAttackL;
                @AttackR.started += instance.OnAttackR;
                @AttackR.performed += instance.OnAttackR;
                @AttackR.canceled += instance.OnAttackR;
                @Knockdown.started += instance.OnKnockdown;
                @Knockdown.performed += instance.OnKnockdown;
                @Knockdown.canceled += instance.OnKnockdown;
                @Face.started += instance.OnFace;
                @Face.performed += instance.OnFace;
                @Face.canceled += instance.OnFace;
                @Facing.started += instance.OnFacing;
                @Facing.performed += instance.OnFacing;
                @Facing.canceled += instance.OnFacing;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @LightHit.started += instance.OnLightHit;
                @LightHit.performed += instance.OnLightHit;
                @LightHit.canceled += instance.OnLightHit;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Roll.started += instance.OnRoll;
                @Roll.performed += instance.OnRoll;
                @Roll.canceled += instance.OnRoll;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @WeaponDown.started += instance.OnWeaponDown;
                @WeaponDown.performed += instance.OnWeaponDown;
                @WeaponDown.canceled += instance.OnWeaponDown;
                @WeaponUp.started += instance.OnWeaponUp;
                @WeaponUp.performed += instance.OnWeaponUp;
                @WeaponUp.canceled += instance.OnWeaponUp;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
            }

            private void UnregisterCallbacks(IRPGCharacterActions instance)
            {
                @AttackL.started -= instance.OnAttackL;
                @AttackL.performed -= instance.OnAttackL;
                @AttackL.canceled -= instance.OnAttackL;
                @AttackR.started -= instance.OnAttackR;
                @AttackR.performed -= instance.OnAttackR;
                @AttackR.canceled -= instance.OnAttackR;
                @Knockdown.started -= instance.OnKnockdown;
                @Knockdown.performed -= instance.OnKnockdown;
                @Knockdown.canceled -= instance.OnKnockdown;
                @Face.started -= instance.OnFace;
                @Face.performed -= instance.OnFace;
                @Face.canceled -= instance.OnFace;
                @Facing.started -= instance.OnFacing;
                @Facing.performed -= instance.OnFacing;
                @Facing.canceled -= instance.OnFacing;
                @Jump.started -= instance.OnJump;
                @Jump.performed -= instance.OnJump;
                @Jump.canceled -= instance.OnJump;
                @LightHit.started -= instance.OnLightHit;
                @LightHit.performed -= instance.OnLightHit;
                @LightHit.canceled -= instance.OnLightHit;
                @Move.started -= instance.OnMove;
                @Move.performed -= instance.OnMove;
                @Move.canceled -= instance.OnMove;
                @Roll.started -= instance.OnRoll;
                @Roll.performed -= instance.OnRoll;
                @Roll.canceled -= instance.OnRoll;
                @Aim.started -= instance.OnAim;
                @Aim.performed -= instance.OnAim;
                @Aim.canceled -= instance.OnAim;
                @WeaponDown.started -= instance.OnWeaponDown;
                @WeaponDown.performed -= instance.OnWeaponDown;
                @WeaponDown.canceled -= instance.OnWeaponDown;
                @WeaponUp.started -= instance.OnWeaponUp;
                @WeaponUp.performed -= instance.OnWeaponUp;
                @WeaponUp.canceled -= instance.OnWeaponUp;
                @Sprint.started -= instance.OnSprint;
                @Sprint.performed -= instance.OnSprint;
                @Sprint.canceled -= instance.OnSprint;
            }

            public void RemoveCallbacks(IRPGCharacterActions instance)
            {
                if (m_Wrapper.m_RPGCharacterActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(IRPGCharacterActions instance)
            {
                foreach (var item in m_Wrapper.m_RPGCharacterActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_RPGCharacterActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public RPGCharacterActions @RPGCharacter => new RPGCharacterActions(this);

        // PlayerInput
        private readonly InputActionMap m_PlayerInput;
        private List<IPlayerInputActions> m_PlayerInputActionsCallbackInterfaces = new List<IPlayerInputActions>();
        private readonly InputAction m_PlayerInput_Jump;
        private readonly InputAction m_PlayerInput_Move;
        private readonly InputAction m_PlayerInput_Sprint;
        private readonly InputAction m_PlayerInput_Attack;
        public struct PlayerInputActions
        {
            private @RPGInputs m_Wrapper;
            public PlayerInputActions(@RPGInputs wrapper) { m_Wrapper = wrapper; }
            public InputAction @Jump => m_Wrapper.m_PlayerInput_Jump;
            public InputAction @Move => m_Wrapper.m_PlayerInput_Move;
            public InputAction @Sprint => m_Wrapper.m_PlayerInput_Sprint;
            public InputAction @Attack => m_Wrapper.m_PlayerInput_Attack;
            public InputActionMap Get() { return m_Wrapper.m_PlayerInput; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PlayerInputActions set) { return set.Get(); }
            public void AddCallbacks(IPlayerInputActions instance)
            {
                if (instance == null || m_Wrapper.m_PlayerInputActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_PlayerInputActionsCallbackInterfaces.Add(instance);
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
            }

            private void UnregisterCallbacks(IPlayerInputActions instance)
            {
                @Jump.started -= instance.OnJump;
                @Jump.performed -= instance.OnJump;
                @Jump.canceled -= instance.OnJump;
                @Move.started -= instance.OnMove;
                @Move.performed -= instance.OnMove;
                @Move.canceled -= instance.OnMove;
                @Sprint.started -= instance.OnSprint;
                @Sprint.performed -= instance.OnSprint;
                @Sprint.canceled -= instance.OnSprint;
                @Attack.started -= instance.OnAttack;
                @Attack.performed -= instance.OnAttack;
                @Attack.canceled -= instance.OnAttack;
            }

            public void RemoveCallbacks(IPlayerInputActions instance)
            {
                if (m_Wrapper.m_PlayerInputActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(IPlayerInputActions instance)
            {
                foreach (var item in m_Wrapper.m_PlayerInputActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_PlayerInputActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public PlayerInputActions @PlayerInput => new PlayerInputActions(this);
        private int m_GamepadSchemeIndex = -1;
        public InputControlScheme GamepadScheme
        {
            get
            {
                if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
                return asset.controlSchemes[m_GamepadSchemeIndex];
            }
        }
        private int m_MouseandKeyboardSchemeIndex = -1;
        public InputControlScheme MouseandKeyboardScheme
        {
            get
            {
                if (m_MouseandKeyboardSchemeIndex == -1) m_MouseandKeyboardSchemeIndex = asset.FindControlSchemeIndex("Mouse and Keyboard");
                return asset.controlSchemes[m_MouseandKeyboardSchemeIndex];
            }
        }
        public interface IRPGCharacterActions
        {
            void OnAttackL(InputAction.CallbackContext context);
            void OnAttackR(InputAction.CallbackContext context);
            void OnKnockdown(InputAction.CallbackContext context);
            void OnFace(InputAction.CallbackContext context);
            void OnFacing(InputAction.CallbackContext context);
            void OnJump(InputAction.CallbackContext context);
            void OnLightHit(InputAction.CallbackContext context);
            void OnMove(InputAction.CallbackContext context);
            void OnRoll(InputAction.CallbackContext context);
            void OnAim(InputAction.CallbackContext context);
            void OnWeaponDown(InputAction.CallbackContext context);
            void OnWeaponUp(InputAction.CallbackContext context);
            void OnSprint(InputAction.CallbackContext context);
        }
        public interface IPlayerInputActions
        {
            void OnJump(InputAction.CallbackContext context);
            void OnMove(InputAction.CallbackContext context);
            void OnSprint(InputAction.CallbackContext context);
            void OnAttack(InputAction.CallbackContext context);
        }
    }
}
