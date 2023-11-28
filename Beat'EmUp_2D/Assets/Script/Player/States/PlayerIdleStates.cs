using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleStates : PlayerGroundStates
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
    }

    public override void Tick()
    {
        base.Tick();
       
    }
}
