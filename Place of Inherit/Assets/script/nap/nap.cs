using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nap : MonoBehaviour
{
    bool atcive=false;
    float timer;
    public GameObject hitplayer;
    public GameObject animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(atcive)
        {
            timer += Time.deltaTime;
            if (timer > 2)
            {
                hitplayer.SetActive(true);
                animator.SetActive(false);
            }
            if(timer >2.5)
            {
                hitplayer.SetActive(false); atcive = false;timer = 0;
            }
            

        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.CompareTag("Player")||other.gameObject.CompareTag("enemy")|| other.gameObject.CompareTag("enemy1"))
        {
            animator.SetActive(true);

            atcive = true;
        }
    }
}
