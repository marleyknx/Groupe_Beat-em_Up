using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGroundStates : PlayerStates
{
    public PlayerGroundStates(Player player, PlayerStateMachine stateMachine, string animBoolName) : base(player, stateMachine, animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void FixedTick()
    {
        base.FixedTick();
        Debug.Log(player.isGrounded());
    }

    public override void Tick()
    {
        base.Tick();
        if(player.jumpAction.IsPressed() && player.isGrounded()) stateMachine.ChangeState(player.jumpState);
    }
}
