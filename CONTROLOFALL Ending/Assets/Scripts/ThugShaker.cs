using UnityEngine;

// Come on do tha thug shaker
public class ThugShaker : MonoBehaviour
{
    private Vector3 originalPosition;
    public float shakeStrength;
    void Awake() => originalPosition = transform.position;
    // Update is called once per frame
    void Update()
    {
        transform.position = originalPosition + (Random.onUnitSphere * shakeStrength);
    }
}
