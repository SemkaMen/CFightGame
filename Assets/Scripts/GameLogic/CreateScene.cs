using UnityEngine;

public class CreateScene
{
    private GameObject background, iniBackground;
    private Player player = new Player();

    private void Initialize()
    {
        background = Resources.Load<GameObject>("Prefabs/SceneObjects/Scene");
    }

    public void Create()
    {
        Initialize();
        player.CreatePlayer();
        iniBackground = Object.Instantiate(background);
        iniBackground.transform.position = Vector3.zero;
    }

    public void Destroy()
    {
        Object.Destroy(GameObject.Find("Background(Clone)"));
        //player.DestroyPlayer();
    }
}
