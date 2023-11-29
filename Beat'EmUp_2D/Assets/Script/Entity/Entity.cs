using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Entity : MonoBehaviour, IHitable {
    //Attention, t'es en train de mettre une PlayerStateMachine avec des PlayerStates dans une classe censée d'être de base

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
    public float LastHitTime { get ; set; }

    protected bool facingRight = true;

     public float currentSpeed;

  

    protected virtual void Awake() //<- méthode heritée de Monobehaviour, virtual par défaut. Ça sert à rien si elle est vide.
    {

    }

    protected virtual void Start() //<- méthode heritée de Monobehaviour, virtual par défaut. Ça sert à rien si elle est vide.
    {

    }

    protected virtual void FixedUpdate() //<- méthode heritée de Monobehaviour, virtual par défaut. Ça sert à rien si elle est vide.
    {
      //  isGrounded();

    }

    protected virtual void Update() //<- méthode heritée de Monobehaviour, virtual par défaut. Ça sert à rien si elle est vide.
    {
        animator.SetBool("IsMoving", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x) > 0);
    }


    // Les fonctions ici en bas ne dévraient pas appartenir à Entity car ils s'occupent du rendu du gameobject -> Single Responsibility
    // Il faudrait les bouger dans un script qui s'occupe du mouvement.
    #region Flip
    public virtual void flip()  //pourquoi virtual ?
    {
        facingDir = facingDir * -1;
        facingRight = !facingRight;
        transform.Rotate(0, 180, 0); //Cette transformation t'oblige à avoir des sprites de double face, pour un petit jeu ce n'est pas grave, pour les grands tu perds la perf

    }
    protected virtual void FlipController(float xvelocity) //pourquoi virtual ?
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

    public void TakeHit(GameObject hitSource) {
        if (Time.time > LastHitTime && hitSource != gameObject) {
            LastHitTime = Time.time + 0.5f;
            Debug.Log($"{gameObject.name} a reçu un coup de {hitSource.name}!");
        }
    }

    #endregion



}
