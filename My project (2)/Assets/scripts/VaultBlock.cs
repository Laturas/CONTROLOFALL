using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaultBlock : MonoBehaviour
{
    public int changeAmount;
    private bool triggered = false;
    public SO_Properties props;
    public Renderer thisMat;
    public float lerpProgress;
    public Color toColor = new Color(0.25f, 0f, 0.5f, 1f);
    // Start is called before the first frame update
    void Start()
    {
        thisMat = GetComponent<Renderer>();
    }

    // Update is called once per frame
    //void Update()
    //{
    //    thisMat.material.SetColor("_Color", toColor);
    //}
    public void Highlight() {

    }
    public void Trigger() {
        if (triggered) {
            EndingChecker.instance.ModifyAndCheck(-changeAmount);
            triggered = false;
            thisMat.material.SetColor("_Color", props.inactiveBlockColor);
            return;
        }
        EndingChecker.instance.ModifyAndCheck(changeAmount);
        triggered = true;
        thisMat.material.SetColor("_Color", props.activatedBlockColor);
    }
    public void Deactivate() {

    }
    public void Unhighlight() {

    }
}
