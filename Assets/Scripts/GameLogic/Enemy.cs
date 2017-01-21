using UnityEngine;
using System.Collections;
using System.Linq;

public class Enemy : MonoBehaviour
{
    private GameObject[] enemies;
    private GameObject[] enemiesQueue;

    private GameObject enemy, spawnPoint, attackPoint, currentEnemy;

    private string[] stringsTags = { "ylw", "blue", "red" };

    private float step = 3f * Time.deltaTime;

    private Color[] colors = { Color.yellow, Color.blue, Color.red };

    private bool gameStart = false;
    public bool isWalk = false;

    private void Awake()
    {
        Initialize();
        CreateEnemy();
    }

    public void Initialize()
    {
        enemies = Resources.LoadAll<GameObject>("Prefabs/SceneObjects/Enemies");

        if (GameObject.Find("_EnemySpawnPoint") != null)
        {
            spawnPoint = GameObject.Find("_EnemySpawnPoint");
        }

        if (GameObject.Find("_EnemyAttackPoint") != null)
        {
            attackPoint = GameObject.Find("_EnemyAttackPoint");
        }
    }

    public void CreateEnemy()
    {
        if (!gameStart)//Если игра только началась, создаем врага в очереди, перемещаем его на атакующую точку
        {
            gameStart = true;

            currentEnemy = Instantiate(enemies[Random.Range(0, enemies.Length)]);
            currentEnemy.transform.localPosition = spawnPoint.transform.position;

            int enemyTypeNumb = Random.Range(0, stringsTags.Length);

            currentEnemy.gameObject.tag = stringsTags[enemyTypeNumb];

            foreach (Transform child in currentEnemy.transform.Cast<Transform>().Where(child => child.transform.name.Contains("Armor")))
            {
                child.gameObject.GetComponent<SpriteRenderer>().color = colors[enemyTypeNumb];
            }

            isWalk = true;
        }
        else
        {
            currentEnemy = Instantiate(enemies[Random.Range(0, enemies.Length)]);
            currentEnemy.transform.localPosition = spawnPoint.transform.position;

            int enemyTypeNumb = Random.Range(0, stringsTags.Length);

            currentEnemy.gameObject.tag = stringsTags[enemyTypeNumb];

            foreach (Transform child in currentEnemy.transform.Cast<Transform>().Where(child => child.transform.name.Contains("Armor")))
            {
                child.gameObject.GetComponent<SpriteRenderer>().color = colors[enemyTypeNumb];
            }
        }
    }

    public void DestroyCurrentEnemy()
    {
        Destroy(currentEnemy);
    }

    private void QueueControl()
    {

    }

    private void EnemyMove()
    {
        if (currentEnemy.transform.position == attackPoint.transform.position)
        {
            isWalk = false;
            CreateEnemy();
        }
        else
        {
            currentEnemy.transform.position = Vector3.MoveTowards(currentEnemy.transform.position, attackPoint.transform.position, step);
        }
    }

    public void AnimPlay(string clipName)
    {
        currentEnemy.gameObject.GetComponent<Animator>().SetTrigger(clipName);
    }

    public void AudioPlay(string clipName)
    {

    }

    private void Update()
    {
        if (isWalk)
        {
            EnemyMove();
        }
    }

}
