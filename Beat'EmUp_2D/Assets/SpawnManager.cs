using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float timer;
    public float spawnMonster;


    



    [System.Serializable]
    public class WaveContent
    {
        [SerializeField][NonReorderable] GameObject[] monsterSpawn;

         public float EnemySpawnTimer,enemySpawnCDR;
        public GameObject[] GetMonsterSpawnList()
        {
            return monsterSpawn;
        }
    }

    [SerializeField] WaveContent[] Waves;
    int currentWave = 0;
    public Transform[] spawnerPoint;
    public int enemiesKilled;
    public List<GameObject> currentMonster;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(UnityEngine.InputSystem.Keyboard.current.iKey.wasPressedThisFrame)SpawnWaves();

        timer -= Time.deltaTime;
        spawnMonster -= Time.deltaTime;
        if (currentMonster.Count == 0 )
        {

            currentWave++;
            SpawnWaves();
        }

    }


    void SpawnWaves()
    {
        for (int i = 0; i < Waves[currentWave].GetMonsterSpawnList().Length; i++)
        {
                GameObject newSpawn = Instantiate(Waves[currentWave].GetMonsterSpawnList()[i], spawnerPoint[i].position, Quaternion.identity);
                currentMonster.Add(newSpawn);

                Enemy monster = newSpawn.GetComponent<Enemy>();
                monster.SetSpawner(this);

            if(Time.time > Waves[currentWave].EnemySpawnTimer + Waves[currentWave].enemySpawnCDR)
            {
                Waves[currentWave].EnemySpawnTimer = Time.time;

            }

               
         

        }
    }
}
