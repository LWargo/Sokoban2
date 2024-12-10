using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Button starter;
    public int index;
    
    void Start()
    {
        starter.onClick.AddListener(() => startGame());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void startGame(){
        SceneManager.LoadScene(index);
    }
}
