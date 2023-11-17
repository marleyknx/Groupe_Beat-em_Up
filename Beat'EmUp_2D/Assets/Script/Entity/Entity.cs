using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Entity : MonoBehaviour
{

    #region states
    public PlayerStateMachine stateMachine { get;  set; }
    public PlayerIdleStates idlestate { get;  set; }
    public PlayerWalkState walkstate { get;  set; }
     public PlayerJumpState jumpState { get;  set; }
      public PlayerAirState airState { get;  set; }
     /* public PlayerNormalShootState normalShootState { get; private set; }
      public PlayerSlideState slideState { get; private set; }
    
    */
    #endregion






    public Rigidbody2D rb;
    public Animator animator;


    protected int facingDir { get; private set; } = 1;
    protected bool facingRight = true;

     public float currentSpeed;

  

    protected virtual void Awake()
    {

    }

    protected virtual void Start()
    {

    }

    protected virtual void FixedUpdate()
    {
      //  isGrounded();

    }

    protected virtual void Update()
    {

    }

    #region Flip
    public virtual void flip()
    {
        facingDir = facingDir * -1;
        facingRight = !facingRight;
        transform.Rotate(0, 180, 0);

    }
    protected virtual void FlipController(float xvelocity)
    {
        if (rb.velocity.x > 0 && !facingRight) flip(); else if (rb.velocity.x < 0 && facingRight) flip();

    }
    #endregion
    #region Velocity
    public void SetVelocity(float velocityX, float velocityY)
    {
        FlipController(velocityX);
        rb.velocity = new Vector2(velocityX, velocityY);

    }
    public void ZeroVelocity() => rb.velocity = new Vector2(0, 0);
    #endregion


  
}
