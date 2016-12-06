using UnityEngine;

public class GameIni : MonoBehaviour {

    private MainGUI mainGui = new MainGUI();
    private BattleGUI battleGui = new BattleGUI();
    private Player player = new Player();

	void Start () {
        battleGui.Create();
        player.CreatePlayer();
	    
	}

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            player.DestroyPlayer();
        }
        else if (Input.GetMouseButtonDown(1))
        {
            player.CreatePlayer();
        }
    }

}
