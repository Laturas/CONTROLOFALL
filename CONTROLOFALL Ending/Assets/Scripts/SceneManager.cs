using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    int phase = 0;
    [SerializeField] float[] times = new float[5];
    [SerializeField] GameObject[] scenes = new GameObject[5];
    [SerializeField] GameObject postProc;

    // Update is called once per frame
    void FixedUpdate() {
        times[phase] -= Time.fixedDeltaTime;
        if (times[phase] < 0f) {SwitchScene();}
    }

    void SwitchScene() {
        switch (phase) {
            case 0:
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
                goto case 12;
            case 6:
                postProc.SetActive(false);
                goto case 12;
            case 7:
            case 8:
            case 9:
            case 10:
            case 11:
                postProc.SetActive(true);
                goto case 12;
            case 12:
            default:
                scenes[phase].SetActive(false);
                phase++;
                scenes[phase].SetActive(true);
                return;
        }
    }
}
