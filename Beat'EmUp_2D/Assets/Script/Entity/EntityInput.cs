using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.UIElements;

public abstract class EntityInput : MonoBehaviour {
    public EntityInputValues InputValues { get; private set; }

    // Update is called once per frame
    public virtual void Update() {
        InputValues = GatherInput();
    }

    public abstract EntityInputValues GatherInput();
}

public struct EntityInputValues {
    public Vector2 Move;
    public bool Attack;
}
