using System.Collections.Generic;
using UnityEngine;

public enum GateColor {
    RED, GREEN, BLUE,
}

public static class GateGod
{
    public static List<Gate> gates = new List<Gate>();
    public static void Assign(Gate gate) {
        gates.Add(gate);
    }

    public static void TriggerColor(GateColor color) {
        foreach (Gate gate in gates) {
            if (gate.color == color) {
                gate.UpdateState();
            }
        }
    }
}
