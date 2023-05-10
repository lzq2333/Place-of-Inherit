using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kill : MonoBehaviour
{
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
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerDEATH.dead = true;
        }
        if (other.gameObject.CompareTag("enemy"))
        {
            Debug.Log("a");
            enemydead.enemy = true;
        }
        if (other.gameObject.CompareTag("enemy1"))
        {
            
            enemydead.enemy1 = true;
        }

    }
}
