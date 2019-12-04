using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{
    public string StartScene= "SantaAdventure";

    public static Gameover Instance;

    private void Awake()
    {
        Instance = this;
        this.gameObject.SetActive(false);
    }

    
    void Start()
    {
        
    }

    public void SendGameover()
    {
        this.gameObject.SetActive(true);
    }


    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("SantaAdventure");
        }   
    }
}
