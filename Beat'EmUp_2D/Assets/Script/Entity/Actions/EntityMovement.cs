using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityMovement : MonoBehaviour
{

    Rigidbody2D rb;
   public bool isMoving { get;  set; }
    public float currentSpeed;

    EntityInput entityInput;


    Vector2 move;
     
    


    private void Awake()
    {
        entityInput = GetComponent<EntityInput>();

       move = entityInput.InputValues.Move;

    }
    // Start is called before the first frame update
    void Start()
    {
        isMoving = true; 
    }

    // Update is called once per frame
    void Update()
    {
       


    }

    private void FixedUpdate()
    {
        SetMovemntDirection(move);
    }

    public void SetMovemntDirection(Vector2 direction)
    {
        if (!isMoving) return;
        rb.velocity = new Vector2 (direction.x * currentSpeed, direction.y * currentSpeed).normalized;
    }
    
    public void SetZeroMovemnent(Vector2 movemnent)
    {
        movemnent = Vector2.zero;
        
    }
  
}
