using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : Entity 
{

  

    public PlayerInput playerInput { get; private set; }
    [HideInInspector]
    public InputAction moveAction, jumpAction, AttackAction, DashAction;


    [Header("Component info")]
    public float currentJump = 8;
    public Vector2 movement { get; private set; }


    [Header("security info")]
    public bool IsMoving;



    protected override void Awake()
    {
        base.Awake();
        #region states
        stateMachine = new PlayerStateMachine();
        idlestate = new PlayerIdleStates(this, stateMachine, "Idle");
        walkstate = new PlayerWalkState(this, stateMachine, "Walk");
         jumpState = new PlayerJumpState(this, stateMachine, "Jump");
        airState = new PlayerAirState(this, stateMachine, "Jump");
        #endregion

        #region Input
        playerInput = GetComponent<PlayerInput>();
        moveAction = playerInput.actions["Walk"];
        jumpAction = playerInput.actions["Jump"];
        #endregion
    }


    // Start is called before the first frame update
   protected override void Start()
    {
        base.Start();
        stateMachine.Initialize(idlestate);
    }

    // Update is called once per frame
   protected override void Update()
    {
        base.Update();
        stateMachine.currentState.Tick();
         movement = moveAction.ReadValue<Vector2>();
     
        Debug.Log(movement);
    }

    protected override void FixedUpdate()
    {

        base.FixedUpdate();
        stateMachine.currentState.FixedTick();
        
      

    }




    #region PlayerComponent
   

   

    //public void AnimationTrigger() => stateMachine.currentState.AnimationFinishTrigger();

   // public virtual bool isSlided() => Physics2D.Raycast(SlideCheck.position, Vector2.down, SlideCheckDistance, layerSlide);

    #endregion
}
