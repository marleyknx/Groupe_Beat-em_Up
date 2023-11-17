using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpState : PlayerStates
{
    public PlayerJumpState(Player player, PlayerStateMachine stateMachine, string animBoolName) : base(player, stateMachine, animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();
        player.SetVelocity(player.movement.x * player.currentSpeed, player.movement.y * player.currentJump);
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void FixedTick()
    {
        base.FixedTick();
        if (rb.velocity.y < 0) stateMachine.ChangeState(player.airState);
    }

    public override void Tick()
    {
        base.Tick();
        
    }
}
