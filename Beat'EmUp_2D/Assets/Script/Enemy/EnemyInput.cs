using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInput : EntityInput {
    public override EntityInputValues GatherInput() {
        return new EntityInputValues {
            Move = EvaluateDirection(),
        };
    }

    private Vector2 EvaluateDirection() {
        //code pour savoir qu'estce quon fait

        return new Vector2(-1, 0); //remplacer par l'evaluation de l'ennemi
    }
}
