using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalkState : PlayerStates
{
    public PlayerWalkState(Player player, PlayerStateMachine stateMachine, string animBoolName) : base(player, stateMachine, animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();
        player.IsMoving = true;

    }

    public override void Exit()
    {
        base.Exit();
        player.ZeroVelocity();
        player.IsMoving = false;

    }

    public override void FixedTick()
    {
        base.FixedTick();
        var normalizedMovement = player.movement.normalized;
        player.SetVelocity(normalizedMovement.x * player.currentSpeed, normalizedMovement.y * player.currentSpeed);
     
    }

    public override void Tick()
    {
        base.Tick();
        if (player.movement == Vector2.zero) stateMachine.ChangeState(player.idlestate);
    }
}
