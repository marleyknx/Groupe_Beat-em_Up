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
       anim.SetBool(animBoolName, true);
       // triggerCalled = false;
         Debug.Log(" je rentre dans " + animBoolName);
    }
    public virtual void Tick()
    {
        Debug.Log(" je suis dans " + animBoolName);
        // calcule l'anim du saut via la velocity y
       anim.SetFloat("VelocityY", rb.velocity.y);
       // stateTimer -= Time.deltaTime;
       // player.slideUsageTimer -= Time.deltaTime;
    }

    public virtual void FixedTick()
    {

    }

    public virtual void Exit()
    {
         Debug.Log(" je sors de " + animBoolName);
        anim.SetBool(animBoolName, false);
    }

}
