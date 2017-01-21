using UnityEngine;
using UnityEngine.UI;

public class barcontroller : MonoBehaviour
{
    public float speed = 0.01f;
    private float currentEnergy;

    void Update()
    {
        currentEnergy = gameObject.GetComponent<Image>().fillAmount -= speed;
    }
}
