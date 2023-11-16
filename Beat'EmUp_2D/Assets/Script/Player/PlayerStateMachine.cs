using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine
{
    public PlayerStates currentState { get; private set; }

    public void Initialize(PlayerStates _state)
    {
        currentState = _state;
        currentState.Enter();
    }

    public void ChangeState(PlayerStates _newState)
    {

        currentState.Exit();
        currentState = _newState;
        currentState.Enter();
    }
}
