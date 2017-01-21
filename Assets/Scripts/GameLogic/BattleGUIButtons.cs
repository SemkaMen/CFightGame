using UnityEngine;
using System.Collections;

public class BattleGUIButtons : MonoBehaviour
{
    Enemy enemy = new Enemy();
    public void YlwBtn()
    {
        enemy.CreateEnemy();
    }
    public void BlueBtn()
    {
        enemy.DestroyCurrentEnemy();
    }
    public void RedBtn()
    {

    }
}
