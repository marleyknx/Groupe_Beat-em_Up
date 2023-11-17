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
        
       // timer d'etat qui nous fais passer du saut a air state

        stateTimer = 1;

       
    }

    public override void Exit()
    {
        base.Exit();
        // laisse la position de l'ombre la ou il sera puis ont le fais revenir dans air state

        player.shadow.position = Vector3.zero;
    }

    public override void FixedTick()
    {
        base.FixedTick();
      
     
        if (stateTimer < 0) stateMachine.ChangeState(player.airState);
    }

    public override void Tick()
    {
        base.Tick();
        
    }
}
