using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndZone : MonoBehaviour
{
    public int boxCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("endzone entered");
        if(other.CompareTag("Coin")){
            boxCounter++;
            //SceneManager.LoadScene(index);
        }
        
    }
}
