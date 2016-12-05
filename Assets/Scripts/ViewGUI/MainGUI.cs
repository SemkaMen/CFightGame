using UnityEngine;
using UnityEditor;

public class MainGUI : MonoBehaviour
{
    private  GameObject mainGUIprefab, canvas;
    
    private void Initialize()
    {
        mainGUIprefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefabs/UI/MainGUI.prefab");
        canvas = GameObject.Find("Canvas");
    }

    public void Create()
    {
        Initialize();
        GameObject sp = Instantiate(mainGUIprefab);
        sp.transform.SetParent(canvas.transform);
        sp.GetComponent<RectTransform>().localPosition = new Vector3(0, sp.GetComponent<RectTransform>().localPosition.y);
    }
}
