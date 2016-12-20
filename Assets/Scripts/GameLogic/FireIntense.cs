using UnityEngine;

public class FireIntense : MonoBehaviour {
    public float minIntensity = 1f;
    public float maxIntensity = 2f;

    private float random;

    private void Start()
    {
        random = Random.Range(0.0f, 65535.0f);
    }

    private void Update()
    {
        float noise = Mathf.PerlinNoise(random, Time.time);
        gameObject.GetComponent<Light>().intensity = Mathf.Lerp(minIntensity, maxIntensity, noise);
    }
}

