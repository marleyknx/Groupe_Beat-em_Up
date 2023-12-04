using Unity.VisualScripting;
using UnityEngine;


public class AttackAnimationEvent : MonoBehaviour {
    [SerializeField] GameObject _hitCollider;
    
    public void EnableHitCollider() {
        _hitCollider.SetActive(true);
        _hitCollider.GetComponent<BoxCollider2D>().size = new Vector2(0.25f, 0.45f);
    }

    public void DisableHitCollider() {
        _hitCollider.SetActive(false);
        _hitCollider.GetComponent<BoxCollider2D>().size = new Vector2(0, 0);
    }
}