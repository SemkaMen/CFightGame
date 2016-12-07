using UnityEngine;
using System.Collections;
using UnityEditor;

public class MainMenu : MonoBehaviour
{

    public void Play()
    {
        //GameObject gameIni = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefabs/GameIni.prefab");
        //Instantiate(gameIni);
        GameObject mainMenu = GameObject.Find("MainMenu");
        mainMenu.gameObject.SetActive(false);
        if (mainMenu.gameObject.activeSelf)
        {
            mainMenu.gameObject.SetActive(false);
        }

    }
    public void Exit()
    {
        Application.Quit();
    }

}
