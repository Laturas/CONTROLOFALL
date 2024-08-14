using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeEnd : MonoBehaviour
{
    public GameObject playerCam;
    public GameObject HOLP;
    public GameObject neverDieParticles;
    private Animator playerCamAnim;
    public Transform thingToLookAt;
    public Transform playerTransform;
    public Transform camHolp;
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
    void LateUpdate() {
        if (!started) {return;}
        if (cays == 5) {neverDieParticles.SetActive(false); cays++; return;}
        if (cays == 6) {return;}

        timers[cays] -= Time.deltaTime;
        if (timers[cays] <= 0f) {
            cays++;
            if (cays == 1) {
                thisAnim.Play("IdkWhatToNameThis");
            }
            if (cays == 3) {
                playerCamAnim.Play("CutscenePt2");
            }
            if (cays == 4) {
                playerCamAnim.Play("uowthgergthtrw");
                neverDieParticles.SetActive(true);
            }
        }

        switch (cays) {
            case 0: {
                playerCam.transform.position = Vector3.Lerp(playerCam.transform.position, HOLP.transform.position, Time.deltaTime);
                playerCam.transform.rotation = 
                Quaternion.Lerp(playerCam.transform.rotation, Quaternion.LookRotation(thingToLookAt.position - playerCam.transform.position, thingToLookAt.up), Time.deltaTime);
                return;
            }
            case 1: return;
            case 2: {
                playerCam.transform.position = Vector3.Lerp(playerCam.transform.position, camHolp.position, Time.deltaTime);
                playerCam.transform.rotation = 
                Quaternion.Lerp(playerCam.transform.rotation, Quaternion.LookRotation(playerTransform.position - playerCam.transform.position, playerTransform.up), Time.deltaTime);
                return;
            }
            case 3:
                playerCam.transform.position = Vector3.Lerp(playerCam.transform.position, HOLP.transform.position, Time.deltaTime);
                playerCam.transform.rotation = 
                Quaternion.Lerp(playerCam.transform.rotation, Quaternion.LookRotation(thingToLookAt.position - playerCam.transform.position, thingToLookAt.up), Time.deltaTime);
                return;
            case 4:
                playerCam.transform.position = Vector3.Lerp(playerCam.transform.position, HOLP.transform.position, Time.deltaTime);
                playerCam.transform.rotation = 
                Quaternion.Lerp(playerCam.transform.rotation, Quaternion.LookRotation(thingToLookAt.position - playerCam.transform.position, thingToLookAt.up), Time.deltaTime);
                return;
            default:
                return;
        }
    }
}
