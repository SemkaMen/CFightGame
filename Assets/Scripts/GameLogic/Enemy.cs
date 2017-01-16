using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    private GameObject[] enemies;
    Sprite[] sprites;
    private GameObject enemy, iniEnemy, spawnPoint;

    private void Awake()
    {
        CreateEnemy();
    }

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
        GameObject curEnemy = enemies[Random.Range(0, enemies.Length)];
        iniEnemy = Instantiate(curEnemy);
        string taG = curEnemy.gameObject.tag;
        iniEnemy.transform.SetParent(spawnPoint.transform);
        iniEnemy.transform.localPosition = Vector3.zero;
    }

    public void DestroyCurrentEnemy()
    {

    }
}
