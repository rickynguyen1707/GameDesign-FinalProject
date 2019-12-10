using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{
    public string StartScene= "SantaAdventure";
    public static Gameover Instance;
    public GameObject Player;
    public GameObject Camera;
    public GameObject level4Spawn;
    public GameObject level5Spawn;
    public GameObject level6Spawn;
    private GameObject[] randombox;

    private void Awake()
    {
        Instance = this;
        this.gameObject.SetActive(false);
    }

    
    void Start()
    {
        randombox = GameObject.FindGameObjectsWithTag("RandomBox");
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
            for (int i = 0; i < randombox.Length; i++)
            {
                randombox[i].GetComponent<BoxCollider2D>().enabled = false;
            }
            if (Player.transform.position.x >= 104.5f && Player.transform.position.x <= 110.5f)
            {
                //SceneManager.LoadScene("SantaAdventure");
                Player.transform.position = level4Spawn.transform.position;
                Player.GetComponent<Renderer>().enabled = true;
                this.gameObject.SetActive(false);
                
            }
            else if(Player.transform.position.x >= 118.5f && Player.transform.position.x <= 151.5f)
            {
                //SceneManager.LoadScene("SantaAdventure");
                Player.transform.position = level5Spawn.transform.position;
                Player.GetComponent<Renderer>().enabled = true;
                this.gameObject.SetActive(false);
            }
            else if (Player.transform.position.x >= 159.5f && Player.transform.position.x <= 191.5f)
            {
                //SceneManager.LoadScene("SantaAdventure");
                Player.transform.position = level6Spawn.transform.position;
                Player.GetComponent<Renderer>().enabled = true;
                this.gameObject.SetActive(false);
            }
        }   
    }
}
