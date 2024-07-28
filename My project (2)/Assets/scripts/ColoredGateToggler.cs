using UnityEngine;

public class ColoredGateToggler : MonoBehaviour, IInteractable
{
    [SerializeField] private GateColor color;
    public void Trigger()
    {
        GateGod.TriggerColor(color);
    }
}
