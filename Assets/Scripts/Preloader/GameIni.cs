using UnityEngine;

public class GameIni : MonoBehaviour {

    //private MainGUI mainGui = new MainGUI();
    private BattleGUI battleGui = new BattleGUI();
    //private Player player = new Player();
    private CreateScene createScene = new CreateScene();

	void Start () {
        battleGui.Create();
        createScene.Create();
        createScene.CreatePlayer();
	}

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            createScene.DestroyPlayer();
        }
        else if (Input.GetMouseButtonDown(1))
        {
            createScene.CreatePlayer();
        }
    }

}
