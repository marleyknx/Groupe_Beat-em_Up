using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleStates : PlayerStates
{
    public PlayerIdleStates(Player player, PlayerStateMachine stateMachine, string animBoolName) : base(player, stateMachine, animBoolName)
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
        if (player.movement.x != 0 || player.movement.y != 0) stateMachine.ChangeState(player.walkstate);
    }

    public override void Tick()
    {
        base.Tick();
       
    }
}
