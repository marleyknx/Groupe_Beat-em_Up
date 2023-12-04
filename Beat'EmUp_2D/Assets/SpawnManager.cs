using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float timer;

    [System.Serializable]
    public class WaveContent
    {
        [SerializeField][NonReorderable] GameObject[] monsterSpawn;

        
        public GameObject[] GetMonsterSpawnList()
        {
            return monsterSpawn;
        }
    }

    [SerializeField] WaveContent[] Waves;
   public int currentWave = 0;
    public Transform[] spawnerPoint;
    public int enemiesKilled;
    public List<GameObject> currentMonster;

    public bool canSpawn;


    private void Start()
    {
        SpawnWaves();
    }



    // Update is called once per frame
    void Update()
    {
       // OnSpawn?.Invoke();

        timer -= Time.deltaTime;
       
        if (currentMonster.Count == 0  )
        {

           currentWave++;
            SpawnWaves();
            
        }
      
    }


   public void SpawnWaves()
    {
        for (int i = 0; i < Waves[currentWave].GetMonsterSpawnList().Length; i++)
        {
                GameObject newSpawn = Instantiate(Waves[currentWave].GetMonsterSpawnList()[i], spawnerPoint[i].position, Quaternion.identity);
                currentMonster.Add(newSpawn);

                Enemy monster = newSpawn.GetComponent<Enemy>();
                monster.SetSpawner(this);

                EnemyInput enemyInput = newSpawn.GetComponent<EnemyInput>();
            enemyInput.target = GameObject.FindGameObjectWithTag("Player");


            timer = 2;

        }
    }
}
