using UnityEngine;
using System.Collections.Generic;

public class DomainReloader : MonoBehaviour
{
    void Awake() {
        if (GateGod.gates != null) {
            GateGod.gates.Clear();
        }
        GateGod.gates = new List<Gate>();
    }
}
