using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class first : MonoBehaviour
{
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
        if(other.gameObject.CompareTag("Player"))
        {
            NewBehaviourScript.vict = true;
            NewBehaviourScript.move = false;
            NewBehaviourScript.fai = false;
            talk.SetActive(true);
          
        }
    }
}
