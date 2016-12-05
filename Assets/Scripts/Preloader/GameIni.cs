using UnityEngine;
using System.Collections;

public class GameIni : MonoBehaviour {

    private MainGUI mainGui = new MainGUI();
    private BattleGUI battleGui = new BattleGUI();
    private Player player = new Player();

	void Start () {
        battleGui.Create();
        player.Create();
	}

}
