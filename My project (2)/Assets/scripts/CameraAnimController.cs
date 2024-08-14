using UnityEngine;

public class CameraAnimController : MonoBehaviour
{
    private AudioListener theAud;
    void Awake() => theAud = GetComponent<AudioListener>();
    // Start is called before the first frame update
    void Start()
    {
        PlayerProperties.canMove = true;
    }
    public void killAudio() {
        theAud.enabled = false;
    }
}
