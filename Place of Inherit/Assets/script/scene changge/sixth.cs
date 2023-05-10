using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sixth : MonoBehaviour
{
    public static bool chest;
    public GameObject talk;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        chest = true;
        talk.SetActive(true);
        NewBehaviourScript.vict = true;
        NewBehaviourScript.move = false; NewBehaviourScript.fai = false;
    }
}
