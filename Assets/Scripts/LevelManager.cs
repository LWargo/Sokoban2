using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int index;
    public Button restart;
    public EndZone ez;
    public GameObject endscreen;
    public Button mainmenu;
    void Start()
    {
        restart.onClick.AddListener( () => reset() );
        mainmenu.onClick.AddListener( () => menu() );
        endscreen.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player") && ( ez.boxCounter == 2 ) ){
            if(index != 2){
                index++;
                SceneManager.LoadScene(index);
            }
            if(index == 2){
                endscreen.gameObject.SetActive(true);
            }
            
        }
        
    }
    void reset(){
        Debug.Log("resetting");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }
    void menu(){
        index++;
        SceneManager.LoadScene(index);
    }
}
