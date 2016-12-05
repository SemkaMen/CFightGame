using UnityEngine;
using UnityEditor;

public class BattleGUI : MonoBehaviour {

    private GameObject battleGUIprefab, canvas;

    private void Initialize()
    {
        battleGUIprefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Resources/Prefabs/UI/BattleGUI.prefab");
        canvas = GameObject.Find("Canvas");
    }

    public void Create()
    {
        Initialize();
        GameObject sp = Instantiate(battleGUIprefab);
        sp.transform.SetParent(canvas.transform);
        sp.GetComponent<RectTransform>().localPosition = new Vector3(0, sp.GetComponent<RectTransform>().localPosition.y);
    }
}
