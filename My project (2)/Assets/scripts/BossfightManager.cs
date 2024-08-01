using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static SO_StartConditions.StartCondition;

public class BossfightManager : MonoBehaviour
{
    [SerializeField] private SO_StartConditions startConditions;
    [SerializeField] private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        if (startConditions.startCondition != BossFight) {
            gameObject.SetActive(false);
        }
        PlayerProperties.canMove = false;
        player.GetComponent<AudioSource>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
