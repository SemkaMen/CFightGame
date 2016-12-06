using UnityEngine;
using System.Collections;

public class CreateScene : MonoBehaviour {
    private GameObject background, iniBackground, player, iniPlayer;
    private Vector3 posVector3;
    private Camera mainCamera;

    private void Initialize()
    {
        background = Resources.Load<GameObject>("Prefabs/SceneObjects/Background"); ;
        mainCamera = Camera.main;
        posVector3 = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width / 2f, Screen.height / 3f, 1));
        player = Resources.Load<GameObject>("Prefabs/SceneObjects/Player");
    }

    public void Create()
    {
        if (GameObject.Find("Background(Clone)") == null)
        {
            Initialize();
            iniBackground = Instantiate(background);
            iniBackground.transform.position = Vector3.zero;
        }
        else
        {
            Debug.Log("Player already created");
        }
    }

    public void Destroy()
    {
        if (GameObject.Find("Background(Clone)") != null)
        {
            Destroy(GameObject.Find("Background(Clone)"));
        }
        else
        {
            Debug.Log("Player don't exist");
        }
    }

    public void CreatePlayer()
    {
        if (GameObject.Find("Player(Clone)") == null)
        {
            Initialize();
            iniPlayer = Instantiate(player);
            iniPlayer.transform.position = posVector3;
        }
        else
        {
            Debug.Log("Player already created");
        }
    }

    public void DestroyPlayer()
    {
        if (GameObject.Find("Player(Clone)") != null)
        {
            Destroy(GameObject.Find("Player(Clone)"));
        }
        else
        {
            Debug.Log("Player don't exist");
        }
    }
}
