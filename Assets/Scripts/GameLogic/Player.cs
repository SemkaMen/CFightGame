using UnityEngine;
using System.Collections;
using UnityEditor;

public class Player : MonoBehaviour
{


    private GameObject player, canvas;

    private void Initialize()
    {

        player = AssetDatabase.LoadAssetAtPath<GameObject>("Asset/Prefabs/GameObjects.prefab");
       // canvas = GameObject.Find("Canvas");
    }

    public void Create()
    {
        Initialize();
        GameObject ini = Instantiate(player);
        ini.transform.position = new Vector2(0, 0);
    }
}
