using UnityEngine;

public class GameIni : MonoBehaviour {

    private MainGUI mainGui = new MainGUI();
    private CreateScene createScene = new CreateScene();
    private BattleGUI battleGui = new BattleGUI();


    private float scaleFactor;


    private void Start ()
    {
        mainGui.Create();
        createScene.Create();
        //enemy.CreateEnemy();
	}

    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {

            //player.AnimPlay("attack");
            //player.AnimPlay("idle");
        }
        //float timer = Time.deltaTime;
    }
}
