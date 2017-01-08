using UnityEngine;

public class MainGUI
{
    private GameObject mainGui, iniGUI, canvas;
    private float scaleFactor;

    private void Initialize()
    {
        mainGui = Resources.Load<GameObject>("Prefabs/UI/MainGUI");
        canvas = GameObject.Find("Canvas");
        scaleFactor = Screen.height / 1280f;
    }

    public void Create()
    {
        Initialize();
        iniGUI = Object.Instantiate(mainGui);
        iniGUI.transform.SetParent(canvas.transform);
        iniGUI.GetComponent<RectTransform>().localPosition = new Vector3(0, 
            iniGUI.GetComponent<RectTransform>().localPosition.y);

        iniGUI.GetComponent<RectTransform>().localScale = 
            new Vector3(iniGUI.GetComponent<RectTransform>().localScale.x * scaleFactor, 
            iniGUI.GetComponent<RectTransform>().localScale.y * scaleFactor);

        GameObject.Find("BtnStart").GetComponent<RectTransform>().localPosition = new Vector3(0, 1300);
    }

    public void Destroy()
    {
        Object.Destroy(GameObject.Find("MainGUI(Clone)"));
    }
}
