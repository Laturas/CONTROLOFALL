using UnityEngine;

/**
* This handles anything that happens when you press the space key :P
*/
public class PlayerInteractions : MonoBehaviour
{
    private Animator cubeAnimator;
    [SerializeField] private float radius;
    [SerializeField] private float maxDistance;

    void Awake() => cubeAnimator = GetComponent<Animator>();

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            TriggerFlash();
            ActivateObjects();
        }
    }

    /**
    * Handles the animation, none of the actual logic
    */
    void TriggerFlash() {
        cubeAnimator.Play("CubeFlash", -1, 0f);
    }

    /**
    * Sends the signals to objects that can be interacted with during a flash
    */
    void ActivateObjects() {
        IInteractable interactable;
        
        Collider[] results = Physics.OverlapSphere(transform.position, radius, 1 << 3, QueryTriggerInteraction.Collide);
        foreach (Collider col in results) {
            if (col.TryGetComponent(out interactable)) {
                interactable.Trigger();
            }
        }
    }
}
