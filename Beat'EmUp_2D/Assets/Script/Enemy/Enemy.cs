using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Entity
{

    SpawnManager spawnManager;


    private void OnEnable() {
        Health.OnDeath += KillCharacter;
    }
    private void OnDisable() {
        Health.OnDeath -= KillCharacter;
    }

    public void SetSpawner(SpawnManager _spawn)
    {
        spawnManager = _spawn;
    }

    private void Update()
    {
        if (UnityEngine.InputSystem.Keyboard.current.iKey.wasPressedThisFrame)
        {
            spawnManager.currentMonster.Remove(this.gameObject);
            Destroy(this.gameObject);

        }
    }

    private void KillCharacter(GameObject sender) {
        if (sender != gameObject)
            return;

        StartCoroutine(InitiateDeath());
    }

    private IEnumerator InitiateDeath() {
        animator.SetTrigger("Death");
        gameObject.GetComponent<EntityMovement>().SetZeroMovemnent();
        yield return new WaitForSeconds(1.5f);
        spawnManager.currentMonster.Remove(this.gameObject);
        Destroy(gameObject);
    }
}
