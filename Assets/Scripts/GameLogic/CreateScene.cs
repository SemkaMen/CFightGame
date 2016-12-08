using UnityEngine;

public class CreateScene : MonoBehaviour
{
    private Player player = new Player();
    private GameObject background, iniBackground;

    private void Initialize()
    {
        background = Resources.Load<GameObject>("Prefabs/SceneObjects/Scene");
    }

    public void Create()
    {
        Initialize();
        player.CreatePlayer();
        iniBackground = Instantiate(background);
        iniBackground.transform.position = Vector3.zero;
    }

    public void Destroy()
    {
        Destroy(GameObject.Find("Background(Clone)"));
        player.DestroyPlayer();
    }
}
