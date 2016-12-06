using UnityEngine;
using System.Collections;

public class FireIntense : MonoBehaviour {
    public float minIntensity = 1f;
    public float maxIntensity = 2f;

    float random;

    void Start()
    {
        random = Random.Range(0.0f, 65535.0f);
    }

    void Update()
    {
        float noise = Mathf.PerlinNoise(random, Time.time);
        gameObject.GetComponent<Light>().intensity = Mathf.Lerp(minIntensity, maxIntensity, noise);
    }
}

