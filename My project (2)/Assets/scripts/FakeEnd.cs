using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeEnd : MonoBehaviour
{
    public GameObject playerCam;
    public GameObject HOLP;
    private Animator playerCamAnim;
    public Transform thingToLookAt;
    private AudioSource thisAud;
    private Animator thisAnim;
    public float[] timers;
    public bool started;
    public int cays;
    void Awake() {
        thisAud = gameObject.GetComponent<AudioSource>();
        playerCamAnim = playerCam.GetComponent<Animator>();
        thisAnim = GetComponent<Animator>();
    }

    void OnTriggerEnter() {
        started = true;
        thisAud.enabled = true;
        PlayerProperties.canMove = false;
        playerCamAnim.Play("InterestingCutscene");
    }
    void Update() {
        if (!started) {return;}

        timers[cays] -= Time.deltaTime;
        if (timers[cays] <= 0f) {
            cays++;
            if (cays == 1) {
                thisAnim.Play("IdkWhatToNameThis");
            }
        }

        switch (cays) {
            case 0:
                playerCam.transform.position = Vector3.Lerp(playerCam.transform.position, HOLP.transform.position, Time.deltaTime);
                var lerpRot = Quaternion.Lerp(playerCam.transform.rotation, Quaternion.LookRotation(thingToLookAt.position - playerCam.transform.position, thingToLookAt.up), Time.deltaTime);
                playerCam.transform.rotation = lerpRot;
                return;
            default:
                return;
        }
    }
}
