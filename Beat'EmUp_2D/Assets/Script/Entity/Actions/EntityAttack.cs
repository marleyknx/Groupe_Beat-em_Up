using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityAttack : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private bool _canAttack;
    [SerializeField] private float _attackCooldown;

    private bool _isAttacking;
    private float _lastAttackTime;

    EntityInput _entityInput;

    private void Awake() {
        _entityInput = GetComponent<EntityInput>();
    }
    private void Update() {
        _canAttack = _entityInput.InputValues.Attack;
        Attack();
    }

    public void Attack() {
        if (!_canAttack) { return; }

        if (Time.time >= _lastAttackTime) {
            _animator.SetTrigger("Attack");
            _isAttacking = false;
            _lastAttackTime = Time.time + _attackCooldown;
        }
    }
}
