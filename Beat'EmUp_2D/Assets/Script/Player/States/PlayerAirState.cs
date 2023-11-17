using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAirState : PlayerStates
{
    public PlayerAirState(Player player, PlayerStateMachine stateMachine, string animBoolName) : base(player, stateMachine, animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
        player.SetVelocity(0, rb.velocity.y);
    }

    public override void FixedTick()
    {
        base.FixedTick();
        player.SetVelocity(player.movement.x * player.currentSpeed, rb.velocity.y);
        if (player.isGrounded()) stateMachine.ChangeState(player.idlestate);
    }

    public override void Tick()
    {
        base.Tick();
    }
}
