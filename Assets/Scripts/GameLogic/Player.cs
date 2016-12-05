using UnityEngine;
using System.Collections;
using UnityEditor;

public class Player : MonoBehaviour
{
    private GameObject player, canvas;

    private void Initialize()
    {
        player = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Resources/Prefabs/GameObjects/Player.prefab");
    }

    public void Create()
    {
        Initialize();
        GameObject ini = Instantiate(player);
        ini.transform.position = new Vector2(Screen.width / 2, Screen.height / 2);
    }
}
