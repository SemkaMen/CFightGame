using UnityEngine;
using System.Collections;

public class MainGUIButtons : MonoBehaviour {

    private Player player = new Player();
    private Enemy enemy = new Enemy();
    private BattleGUI battleGui = new BattleGUI();
    private MainGUI mainGui = new MainGUI();

    public void LoadPlayScene()
    {
        mainGui.Destroy();
        battleGui.Create();
        player.CreatePlayer();
        enemy.CreateEnemy();
    }
}
