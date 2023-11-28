using UnityEngine;

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
