using UnityEngine;

public class DamnNowIGottaWriteCodeIG : MonoBehaviour
{
    [SerializeField] GameObject player;

    void TriggerRealStart() {
        player.SetActive(true);
    }
    void DestroySelf() {
        gameObject.SetActive(false);
    }
}
