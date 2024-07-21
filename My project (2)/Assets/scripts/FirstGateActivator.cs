using UnityEngine;
using static FirstGateActivator.GateState;

public class FirstGateActivator : MonoBehaviour, IInteractable
{
    [Header("Indicator Stuff")]
    public Animator flashAnimator;
    public Animator thisAnimator;
    [Header("Gate Stuff")]
    public Transform gateTransform;
    private GateState gateState;
    public Vector3 closedPosition;
    public Vector3 openedPosition;

    public enum GateState {
        Closed,
        Opened,
    }

    void Awake() {
        thisAnimator = GetComponent<Animator>();
        gateState = Closed;
        gateTransform.position = closedPosition;
    }

    public void Trigger() {
        if (gateState == Closed) {gateState = Opened;}
        else {gateState = Closed;}
    }

    void Update() {
        switch (gateState) {
            case Closed:
                if (Vector3.Distance(gateTransform.position, closedPosition) < 0.05f) {return;}
                gateTransform.position = Vector3.Lerp(gateTransform.position, closedPosition, Time.deltaTime);
                return;
            case Opened:
                if (Vector3.Distance(gateTransform.position, openedPosition) < 0.05f) {return;}
                gateTransform.position = Vector3.Lerp(gateTransform.position, openedPosition, Time.deltaTime);
                return;
        }
    }
}
