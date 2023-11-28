using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.UIElements;

public class PlayerInputHandler : EntityInput
{
    private PlayerInput _playerInput;
    private InputAction _moveAction, _attackAction;//, _jumpAction, _dashAction;

    void Awake() {
        _playerInput = GetComponent<PlayerInput>();
        _moveAction = _playerInput.actions["Walk"];
        _attackAction = _playerInput.actions["Attack"];
        //_jump = _playerInput.actions["Jump"];
    }

    public override EntityInputValues GatherInput() {
        return new EntityInputValues {
            Move = _moveAction.ReadValue<Vector2>(),
            Attack = _attackAction.ReadValue<float>() > 0,
        };
    }
}