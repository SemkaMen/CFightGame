using UnityEngine;

public class BattleGUI  {
    
    private GameObject battleGUI, iniGUI, canvas;
    private float scaleFactor;

    private void Initialize()
    {
        battleGUI = Resources.Load<GameObject>("Prefabs/UI/BattleGUI");
        canvas = GameObject.Find("Canvas");
        scaleFactor = Screen.height / 1280f;
    }

    public void Create()
    {
        Initialize();
        iniGUI = Object.Instantiate(battleGUI);
        iniGUI.transform.SetParent(canvas.transform);
        iniGUI.GetComponent<RectTransform>().localPosition = new Vector3(0, iniGUI.GetComponent<RectTransform>().localPosition.y);
        iniGUI.GetComponent<RectTransform>().localScale = new Vector3(iniGUI.GetComponent<RectTransform>().localScale.x * scaleFactor, 
            iniGUI.GetComponent<RectTransform>().localScale.y * scaleFactor);
        GameObject progressBar = GameObject.Find("ProgressBar");
        progressBar.GetComponent<RectTransform>().localPosition = new Vector3(progressBar.GetComponent<RectTransform>().localPosition.x,1200);
    }
}
