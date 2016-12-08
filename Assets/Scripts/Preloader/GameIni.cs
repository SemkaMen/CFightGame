using UnityEngine;

public class GameIni : MonoBehaviour {

    //private MainGUI mainGui = new MainGUI();
    private BattleGUI battleGui = new BattleGUI();
    private Player player = new Player();
    private CreateScene createScene = new CreateScene();
    private Enemy enemy = new Enemy();

	void Start ()
    {
        battleGui.Create();
        createScene.Create();
        enemy.CreateEnemy();
	}

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            player.AnimPlay("attack");
            player.AnimPlay("idle");
        }
    }

}
