using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObjectController : MonoBehaviour
{

    private Vector3 targetPosition;
    PlayerController player;
    bool playerMovement = false;

     void OnMouseDown() {

        playerMovement = true;        
        
    }
    // Start is called before the first frame update
    void Start()
    {
        player = (PlayerController)GameObject.Find("Player").GetComponent(typeof(PlayerController));
    }

    // Update is called once per frame
    void Update()
    {
        if (playerMovement) {
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            player.MoveToPosition(targetPosition);
            Destroy(gameObject);
        }
       
    }
}

