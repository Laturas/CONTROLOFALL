using UnityEngine;

// Come on do tha thug shaker
public class ThugShaker : MonoBehaviour
{
    private Vector3 originalPosition;
    [SerializeField] private Vector3 originalPositionOverride;
    [SerializeField] private bool overridePos = false;
    public float shakeStrength;
    void Awake() => originalPosition = Vector3.zero;
    
    // Update is called once per frame
    void Update()
    {
        if (originalPosition == Vector3.zero && shakeStrength != 0) {
            originalPosition = transform.localPosition;
        }
        if (overridePos) {
            originalPosition = originalPositionOverride;
        }
        transform.localPosition = originalPosition + (Random.onUnitSphere * shakeStrength);
    }
}
