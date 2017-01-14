using UnityEngine;
using System.Collections;

public class MainGUIButtons : MonoBehaviour {

    private BattleGUI battleGui = new BattleGUI();
    private MainGUI mainGui = new MainGUI();
    private CreateScene scene = new CreateScene();

    public void LoadPlayScene()
    {
        mainGui.Destroy();
        battleGui.Create();
        scene.Create();
    }
}
