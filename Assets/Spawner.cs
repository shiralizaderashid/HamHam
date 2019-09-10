using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float startTimeBtwSpawn;

    private float timeBtw;

    public GameObject[] enemies;

    private void Update()
    {
        if (timeBtw <= 0)
        {
            int rand = Random.Range(0, enemies.Length);
            Instantiate(enemies[rand], transform.position, Quaternion.identity);
            timeBtw = startTimeBtwSpawn;
        }
        else
        {
            timeBtw -= Time.deltaTime;
        }
    }
}
