using UnityEngine;
using static SO_StartConditions.StartCondition;

public class DamnNowIGottaWriteCodeIG : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] SO_StartConditions startConditions;
    void Awake() {
        if (startConditions.startCondition == SkipIntro) {
            TriggerRealStart();
            DestroySelf();
        }
    }

    void TriggerRealStart() {
        player.SetActive(true);
    }
    void DestroySelf() {
        gameObject.SetActive(false);
    }
}
