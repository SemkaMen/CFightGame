using UnityEngine;
using UnityEngine.UI;

public class barcontroller : MonoBehaviour
{
    private float speed;
    private float currentEnergy;

    void Start()
    {
        speed = 0.01f;
    }

    void Update()
    {
        currentEnergy = gameObject.GetComponent<Image>().fillAmount -= speed;
    }
}
