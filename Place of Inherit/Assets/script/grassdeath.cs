using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grassdeath : MonoBehaviour
{public Animator animator;
    public GameObject grass;
    float timer;
    bool death=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (death == true) 
            timer+=Time.deltaTime;
        if(timer>1)
        {
            grass.SetActive(false);
        }
    }
     public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("hit")||other.gameObject.CompareTag("enemy")||other.gameObject.CompareTag("enemy1"))
        {
            animator.SetBool("hitted", true);
            death = true;
        }
    }
}
