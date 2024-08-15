using UnityEngine;

public class EndingChecker : MonoBehaviour
{
    public static EndingChecker instance;
    public GameObject theEnd;
    public GameObject deactivateThis;
    public int endValue;
    void Awake() => instance = this;
    void Start() => endValue = 0;

    public void ModifyAndCheck(int changeAmount) {
        endValue += changeAmount;
        if (endValue == 41) {
            theEnd.SetActive(true);
            deactivateThis.SetActive(false);
        }
    }
}
