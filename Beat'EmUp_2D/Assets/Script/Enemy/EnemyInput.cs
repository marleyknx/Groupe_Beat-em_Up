using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInput : EntityInput {

    //detect le joueur
    public GameObject target;
    // detetct l'attack
    public bool inRange;
    Vector2 directionToTarget;

    public override EntityInputValues GatherInput() {
        return new EntityInputValues {
            Move = EvaluateDirection(target),
            Attack = EvaluateAttack(inRange)
        };
    }

    private Vector2 EvaluateDirection(GameObject _target) {
        //code pour savoir qu'estce quon fait
         directionToTarget = _target.transform.position - transform.position;
       directionToTarget.Normalize();
       
            if(inRange)
         return  Vector3.zero;
       else    return new Vector2(directionToTarget.x, directionToTarget.y); //remplacer par l'evaluation de l'ennemi
    }

    public bool EvaluateAttack(bool _inRange)
    {
        
       
       
        return inRange;
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.parent.gameObject == target)
            inRange = true;
    }

    //private void OnTriggerStay2D(Collider2D collision)
    //{
    //    if (collision.transform.parent == target)
    //        inRange = true;
    //}



    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.parent.gameObject == target)
            inRange = false;
    }



}
