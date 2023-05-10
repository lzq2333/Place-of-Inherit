using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDEATH : MonoBehaviour
{
    private float timer=0;
    public static bool dead=false;
    public GameObject player;
    public GameObject boom;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(dead)
        {
            player.SetActive(false);
            timer += Time.deltaTime;
            boom.SetActive(true);
            NewBehaviourScript.fai = true;
        }
        if (timer > 1)
            death();
     }
     void death()
    {
        
        dead = false;
        player.SetActive(true);
        boom.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
