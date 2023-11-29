using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStates 
{
    protected PlayerStateMachine stateMachine;
    protected Player player;
    protected string animBoolName;

    public Rigidbody2D rb;
    public Animator anim;
    public float stateTimer;

    public PlayerStates(Player player, PlayerStateMachine stateMachine, string animBoolName)
    {
        this.stateMachine = stateMachine;
        this.player = player;
        this.animBoolName = animBoolName;
    }

    public virtual void Enter()
    {
        rb = player.rb;
        anim = player.animator;
      // anim.SetBool(animBoolName, true);
       // triggerCalled = false;
    }
    public virtual void Tick()
    {
        // calcule l'anim du saut via la velocity y si on est en saut ou dans les air
        stateTimer -= Time.deltaTime;
       // player.slideUsageTimer -= Time.deltaTime;
    }

    public virtual void FixedTick()
    {

    }

    public virtual void Exit()
    {
      //  anim.SetBool(animBoolName, false);
    }

}
