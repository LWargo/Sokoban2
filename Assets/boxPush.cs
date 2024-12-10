using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxPush : MonoBehaviour
{
    // Start is called before the first frame update
    public float pushPower = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnControllerColliderHit(ControllerColliderHit hit) {
        Debug.Log("hit!");
        Rigidbody rigidbody = hit.collider.attachedRigidbody;
        if(rigidbody != null ){
            Vector3 pushDirection = hit.gameObject.transform.position - transform.position;
            pushDirection.Normalize();
            rigidbody.AddForceAtPosition(pushDirection * pushPower, transform.position, ForceMode.Impulse);
            
        }
    }
}
