using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public static Action<GameObject> OnDeath;

    [SerializeField] private int currentHealth;
    [SerializeField] private int maxHealth;

    private void Start() {
        currentHealth = maxHealth;
    }

    public void Damage(int damage) {
        currentHealth -= damage;
        if (currentHealth < 0) {
            OnDeath?.Invoke(gameObject);
        }
    }
}
