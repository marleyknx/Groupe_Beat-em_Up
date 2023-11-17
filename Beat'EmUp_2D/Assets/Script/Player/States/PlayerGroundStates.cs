using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGroundStates : PlayerStates
{

    // a renommer si besoin 
    public PlayerGroundStates(Player player, PlayerStateMachine stateMachine, string animBoolName) : base(player, stateMachine, animBoolName)
    {
    }

    // permet de faire la passerel entre le saut et le " sol " 
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
        // mettre un second parametre pour savoir si l'ombre reviens a sa position initial si oui on ressaute si non bloque le saut
        if(player.jumpAction.IsPressed() ) stateMachine.ChangeState(player.jumpState);
    }
}
