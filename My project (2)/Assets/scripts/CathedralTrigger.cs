using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CathedralTrigger : MonoBehaviour
{
    public GameObject bossfight;
    public GameObject player;
    private Animator playerAnimator;
    void Awake() {
        playerAnimator = player.GetComponent<Animator>();
    }

    void OnTriggerEnter() {
        PlayerProperties.canFlash = false;
        playerAnimator.Play("Fader");
    }
}
