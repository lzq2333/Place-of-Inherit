using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eye : MonoBehaviour
{
    public GameObject player;
    public static int x;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            
            if (collision.transform.position.x < gameObject.transform.position.x)
            {
                x = -1;
            }
            else
                x = 1;
        }
           

        

    }
    // Update is called once per frame
    void Update()
    {
       
    }
}
