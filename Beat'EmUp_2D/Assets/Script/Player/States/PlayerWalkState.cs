using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalkState : PlayerGroundStates
{
    public PlayerWalkState(Player player, PlayerStateMachine stateMachine, string animBoolName) : base(player, stateMachine, animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();

    }

    public override void Exit()
    {
        base.Exit();
        player.ZeroVelocity();

    }

    public override void FixedTick()
    {
        base.FixedTick();
     
    }

    public override void Tick()
    {
        base.Tick();
    }
}
