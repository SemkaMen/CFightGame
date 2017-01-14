using UnityEngine;

public class GameIni : MonoBehaviour {

    private MainGUI mainGui = new MainGUI();

    private float scaleFactor;


    private void Start ()
    {
        mainGui.Create();
	}

    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {

        }
    }
}
