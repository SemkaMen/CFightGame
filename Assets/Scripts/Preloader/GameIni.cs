using UnityEngine;
using System.Collections;

public class GameIni : MonoBehaviour {

    private MainGUI mainGui = new MainGUI();
    private BattleGUI battleGui = new BattleGUI();

	void Start () {
        battleGui.Create();
	}

}
