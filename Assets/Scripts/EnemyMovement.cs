using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour
{
    private float minX,maxX;
    public float range;
    private bool isFacingRight = true;
    public float mSpeed;
    //public GameObject grave;
    public GameObject ghost;
    // Start is called before the first frame update
    void Start()
    {
        ghost.gameObject.SetActive(false);
        minX = transform.position.x - range;
        maxX = transform.position.x + range;
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector2.right * mSpeed * Time.deltaTime);
        if (isFacingRight && transform.position.x > maxX) Flip();
        if (!isFacingRight && transform.position.x < minX) Flip();
    }

    private void Flip() {
      //  Debug.Log("Flipping");
        isFacingRight = !isFacingRight;
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y + 180, transform.eulerAngles.z);
        /*Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;*/
    }
    void OnTriggerEnter2D(Collider2D other){
        Debug.Log("trigger is hit");
        if(other.CompareTag("Player") && ghost.gameObject.activeSelf == false){
            Debug.Log("enemy activated");
            ghost.gameObject.SetActive(true);
        }
        /*
        if(other.CompareTag("Player") && ghost.gameObject.activeSelf == true){
            Debug.Log("oh no!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        */
    }



    void OnCollisionEnter2D(Collision2D other){
        if(ghost.gameObject.activeSelf == true && gameObject == ghost){
            Debug.Log("oh no!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    
}
