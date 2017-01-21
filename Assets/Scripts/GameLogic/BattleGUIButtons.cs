using UnityEngine;
using System.Collections;

public class BattleGUIButtons : MonoBehaviour
{
    public void YlwBtn()
    {
        GameObject.Find("_EnemyController").GetComponent<Enemy>().CreateEnemy();
    }
    public void BlueBtn()
    {
        GameObject.Find("_EnemyController").GetComponent<Enemy>().DestroyCurrentEnemy();
    }
    public void RedBtn()
    {
        GameObject.Find("_EnemyController").GetComponent<Enemy>().isWalk = true;
    }
}
