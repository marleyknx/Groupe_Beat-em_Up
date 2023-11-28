using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInput : EntityInput {

    //detect le joueur
    public Transform target;
    // detetct l'attack
    public bool inRange;


    public override EntityInputValues GatherInput() {
        return new EntityInputValues {
            Move = EvaluateDirection(target),
            Attack = EvaluateAttack(inRange)
        };
    }

    private Vector2 EvaluateDirection(Transform _target) {
        //code pour savoir qu'estce quon fait
        Vector2 directionToTarget = _target.position - transform.position;
       
        return new Vector2(directionToTarget.x, directionToTarget.y); //remplacer par l'evaluation de l'ennemi
    }

    public bool EvaluateAttack(bool inRange)
    {
        if (inRange) 
        Debug.Log("Attack");
        return inRange;
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision);
        
        if(collision.transform == target)
            inRange = true;
       

        
    }

    private void OnCollisionStay2D(Collision2D collision)
    {

        if (collision.transform == target)
            inRange = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform != target)
            inRange = false;
       
    }



}
