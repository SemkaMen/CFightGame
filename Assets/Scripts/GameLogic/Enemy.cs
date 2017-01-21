using UnityEngine;
using System.Collections;
using System.Linq;

public class Enemy : MonoBehaviour
{
    private GameObject[] enemies;
    private GameObject enemy, iniEnemy, spawnPoint, attackPoint, currentEnemy;
    private string[] stringsTags = {"ylw","blue","red"};
    private Color[] colors = {Color.yellow, Color.blue, Color.red};

    private void Start()
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
        //iniEnemy.transform.SetParent(spawnPoint.transform);
        iniEnemy.transform.localPosition = spawnPoint.transform.position;
        int enemyTypeNumb = Random.Range(0, stringsTags.Length);
        iniEnemy.gameObject.tag = stringsTags[enemyTypeNumb];
        foreach (Transform child in iniEnemy.transform.Cast<Transform>().Where(child => child.transform.name.Contains("Armor")))
        {
            child.gameObject.GetComponent<SpriteRenderer>().color = colors[enemyTypeNumb];
        }
        currentEnemy = iniEnemy;
    }

    public void DestroyCurrentEnemy()
    {
        Destroy(currentEnemy);
    }


}
