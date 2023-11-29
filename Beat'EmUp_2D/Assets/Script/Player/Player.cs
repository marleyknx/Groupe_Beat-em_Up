using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : Entity {


    [Header("Component info")]
    public Transform shadow;

    protected override void Awake() {
        base.Awake();
       stateMachine = new PlayerStateMachine();
        #region states
        idlestate = new PlayerIdleStates(this, stateMachine, "Idle");
        walkstate = new PlayerWalkState(this, stateMachine, "Walk");
        jumpState = new PlayerJumpState(this, stateMachine, "Jump");
        airState = new PlayerAirState(this, stateMachine, "Jump"); //Pourquoi un AirState ?
        #endregion
    }


    // Start is called before the first frame update
    protected override void Start() {
        base.Start();
        stateMachine.Initialize(idlestate);
    }

    // Update is called once per frame
    protected override void Update() {
        base.Update(); // Il n'y a rien dans la base
        stateMachine.currentState.Tick();
    }

    protected override void FixedUpdate() {

        base.FixedUpdate(); //Il n'y a rien dans la base
        stateMachine.currentState.FixedTick();
    }

    #region PlayerComponent




    //public void AnimationTrigger() => stateMachine.currentState.AnimationFinishTrigger();

    // public virtual bool isSlided() => Physics2D.Raycast(SlideCheck.position, Vector2.down, SlideCheckDistance, layerSlide);

    #endregion
}
