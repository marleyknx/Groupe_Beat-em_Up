using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityMovement : MonoBehaviour {

    Rigidbody2D rb;
    public bool isMoving { get; set; }
    public float currentSpeed;

    EntityInput entityInput;

    private void Awake() {
        entityInput = GetComponent<EntityInput>();
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start() {
    }

    // Update is called once per frame
    void Update() {
        isMoving = entityInput.InputValues.Move.magnitude > 0;
    }

    private void FixedUpdate() {
        SetMovemntDirection(entityInput.InputValues.Move);
    }

    public void SetMovemntDirection(Vector2 direction) {
        if (!isMoving)
            SetZeroMovemnent();
        rb.velocity = new Vector2(direction.x * currentSpeed, direction.y * currentSpeed);
    }

    public void SetZeroMovemnent() {
        rb.velocity = Vector2.zero;

    }

}
