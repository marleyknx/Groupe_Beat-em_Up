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
      
    }

    public override void FixedTick()
    {
        base.FixedTick();
        // lorceque le shadow reviens dans sa position initial retourne a idle

       // if () stateMachine.ChangeState(player.idlestate);
    }

    public override void Tick()
    {
        base.Tick();
    }
}
