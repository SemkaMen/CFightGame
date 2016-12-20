using UnityEngine;
using System.Collections;

public class Enemy 
{
    private GameObject[] enemies;
    private GameObject enemy, iniEnemy, spawnPoint;

    public void Initialize()
    {
        enemies = Resources.LoadAll<GameObject>("Prefabs/SceneObjects/Enemies");
        if (GameObject.Find("_EnemySpawnPoint") != null)
        {
            spawnPoint = GameObject.Find("_EnemySpawnPoint");
        }
    }

    public void CreateEnemy()
    {
        Initialize();
        iniEnemy = Object.Instantiate(enemies[Random.Range(0, enemies.Length)]);
        iniEnemy.transform.SetParent(spawnPoint.transform);
        iniEnemy.transform.localPosition = Vector3.zero;
    }
}
