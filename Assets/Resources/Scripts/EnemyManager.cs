using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    [SerializeField] private GameObject enemyToSpawn;
    [SerializeField] private float timeSinceSpawn = 0.0f;
    [Tooltip("When to spawn, or Lowerbound of Range if spawning between range")]
    [SerializeField]
    private float whenToSpawnAt = 5.0f;
    [SerializeField] private bool spawnTimeBetweenRange;
    //This variable is only important if spawning between range;
    private float randomSelection = 5.0f;
    [Tooltip("upperbound of Range if spawning between range")]
    [SerializeField]
    private float spawnUpperBound = 8.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeSinceSpawn += Time.deltaTime;
        SpawnEnemy();
    }

    private void SpawnEnemy()
    {
        if (spawnTimeBetweenRange && timeSinceSpawn >= randomSelection)
        {
            Instantiate(enemyToSpawn, gameObject.transform.position, Quaternion.identity);
            timeSinceSpawn = 0;
            randomSelection = Random.Range(whenToSpawnAt, spawnUpperBound);
        }
        else
        {
            if(timeSinceSpawn >= whenToSpawnAt)
            {
                Instantiate(enemyToSpawn, gameObject.transform.position, Quaternion.identity);
                timeSinceSpawn = 0;
            }
        }
    }
}
