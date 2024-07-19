using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    AudioSource audsrc;
    [SerializeField] private float fadeSpeed;
    // Start is called before the first frame update
    void Awake() {
        audsrc = GetComponent<AudioSource>();
    }
    void Start() {
        audsrc.volume = 0f;
    }

    void Update() {
        if (audsrc.volume != 1f) {
            audsrc.volume += Time.deltaTime / fadeSpeed;
            if (audsrc.volume > 1f) {audsrc.volume = 1f;}
        }
    }
}
