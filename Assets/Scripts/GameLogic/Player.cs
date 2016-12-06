using UnityEngine;

public class Player : MonoBehaviour
{
    private GameObject player, iniPlayer;
    private Camera mainCamera;
    private Vector3 posVector3;

    private void Initialize()
    {
        mainCamera = Camera.main;
        posVector3 = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width/2f, Screen.height/3f, 1));
        player = Resources.Load<GameObject>("Prefabs/GameObjects/Player"); ;
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
