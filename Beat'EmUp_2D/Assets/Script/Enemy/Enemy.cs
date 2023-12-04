using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Entity
{

    SpawnManager spawnManager;
    public void SetSpawner(SpawnManager _spawn)
    {
        spawnManager = _spawn;
    }
}
