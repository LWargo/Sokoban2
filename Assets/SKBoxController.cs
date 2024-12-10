using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SKBoxController : MonoBehaviour
{
    public Vector3 targetPosition;
    private Vector2 movement;
    // Start is called before the first frame update
    void Start()
    { 
        targetPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    transform.position = Vector3.MoveTowards( transform.position,targetPosition, Time.deltaTime * 2);

    }
}
