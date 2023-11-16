using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Entity : MonoBehaviour
{

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


    #region collision

  //  public virtual bool isGrounded() => Physics2D.Raycast(groundCheck.position, Vector2.down, groundCheckDistance, isGround);

   // public virtual bool IsWallDetected() => Physics2D.Raycast(wallCheck.position, Vector2.right * facingDir, wallCheckDistance, isWallOrEnemy);

    protected virtual void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
       // Gizmos.DrawLine(groundCheck.position, new Vector3(groundCheck.position.x, groundCheck.position.y - groundCheckDistance));
        Gizmos.color = Color.white;
       // Gizmos.DrawLine(wallCheck.position, new Vector3(wallCheck.position.x + wallCheckDistance, wallCheck.position.y));

    }
    #endregion
}
