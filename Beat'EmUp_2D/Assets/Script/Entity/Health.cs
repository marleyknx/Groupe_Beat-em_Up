using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int currentHealth;
    [SerializeField] private int maxHealth;

    private void Start() {
        currentHealth = maxHealth;
    }

    public void Damage(int damage) {
        currentHealth -= damage;
    }
}
