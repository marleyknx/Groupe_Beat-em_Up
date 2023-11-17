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

    [SerializeField] protected Transform groundCheck;
    [SerializeField] protected float groundCheckDistance;
    [SerializeField] protected LayerMask isGround;
   
  //  [SerializeField] protected Transform wallCheck;
   // [SerializeField] protected float wallCheckDistance;
   // [SerializeField] protected LayerMask isWallOrEnemy;


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


    #region collision

    // permet de savoir si on touche le si non soit on saute soit on est dans les air
    public virtual bool isGrounded() => Physics2D.Raycast(groundCheck.position, Vector2.down, groundCheckDistance, isGround);

  //  public virtual bool IsWallDetected() => Physics2D.Raycast(wallCheck.position, Vector2.right * facingDir, wallCheckDistance, isWallOrEnemy);

    protected virtual void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(groundCheck.position, new Vector3(groundCheck.position.x, groundCheck.position.y - groundCheckDistance));
        Gizmos.color = Color.white;
       // Gizmos.DrawLine(wallCheck.position, new Vector3(wallCheck.position.x + wallCheckDistance, wallCheck.position.y));

    }
    #endregion
}
