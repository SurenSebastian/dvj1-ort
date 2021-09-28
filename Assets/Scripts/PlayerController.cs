using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject mainPosition;
    public float speed;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveToPosition(mainPosition.transform.position);
       
    }

    public void MoveToPosition(Vector3 target) {

      transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
}