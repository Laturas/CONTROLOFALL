using UnityEngine;

public class Gate : MonoBehaviour
{
    public GateColor color;
    [SerializeField] private bool startOpened;
    public bool opened;
    private GameObject solidGate;
    public void UpdateState() {
        opened = !opened;
        Debug.Log(solidGate==null);
        solidGate.SetActive(!opened);
    }

    void Start() {
        solidGate = GetComponentInChildren<BoxCollider>(true).gameObject;
        solidGate.SetActive(!startOpened);
        opened = startOpened;
        GateGod.Assign(this);
    }
}
