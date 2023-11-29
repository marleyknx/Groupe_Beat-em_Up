using Unity.VisualScripting;
using UnityEngine;


public class AttackAnimationEvent : MonoBehaviour {
    [SerializeField] GameObject _hitCollider;
    
    public void EnableHitCollider() {
        _hitCollider.SetActive(true);
    }

    public void DisableHitCollider() {
        _hitCollider.SetActive(false);
    }
}