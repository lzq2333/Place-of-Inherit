using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

public class NewBehaviourScript : MonoBehaviour
{
    //public AudioClip walk;
    //public AudioSource audio;
    public static bool move = true;
    public static bool vict;
    public static bool fai;
    public bool defend;
    public bool attack;
    public bool left;
    public bool animat;
    public bool music;
    public static bool defend1;
    public float speed = 3.0f;

    public int maxHealth = 5;
    public float timeInvincible = 2.0f;
    public GameObject downhit;
    public GameObject uphit;
    public GameObject lefthit;
    public GameObject righthit;
    public GameObject walk;
    public GameObject victory;
    public GameObject fail;
    public int health { get { return currentHealth; } }
    int currentHealth;

    bool isInvincible;
    float invincibleTimer;

    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;

    Animator animator;
    Vector2 lookDirection = new Vector2(1, 0);
    
    // 在第一次帧更新之前调用 Start
    void Start()
    {
        defend1 = defend;
        rigidbody2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

        currentHealth = maxHealth;
        //audio = GetComponent<AudioSource>();
    }
    //public void PlaySound(AudioClip clip)
    //{
    //    audio.PlayOneShot(clip);
    //}

    // 每帧调用一次 Update
    void Update()
    {
        if (Input.GetKey(KeyCode.P))
            {
            Application.Quit();
        }

            if (Input.GetKey(KeyCode.Z)&&attack)
        {
            animator.SetBool("hit", true);
            if(animator.GetFloat("Look X")>0.5&& animator.GetFloat("Look Y")==0)
            {
                righthit.SetActive(true);
            }
            if (animator.GetFloat("Look X") <-0.5 && animator.GetFloat("Look Y") == 0)
            {
                lefthit.SetActive(true);
            }
            if (animator.GetFloat("Look X") ==0 && animator.GetFloat("Look Y") > 0.5)
            {
                uphit.SetActive(true);
            }
            if (animator.GetFloat("Look X") ==0 && animator.GetFloat("Look Y") <- 0.5)
            {
                downhit.SetActive(true);
            }
            

        }
        else {
            animator.SetBool("hit", false);
            uphit.SetActive(false);
            downhit.SetActive(false); lefthit.SetActive(false); righthit.SetActive(false);
        }
       
        
        if (Input.GetKey(KeyCode.R))
            {
            PlayerDEATH.dead = true;

        }
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        Vector2 move = new Vector2(horizontal, vertical);
        if(animat)
        {
            if (!Mathf.Approximately(move.x, 0.0f) || !Mathf.Approximately(move.y, 0.0f))
            {
                lookDirection.Set(move.x, move.y);
                lookDirection.Normalize();
            }

            animator.SetFloat("Look X", lookDirection.x);
            animator.SetFloat("Look Y", lookDirection.y);
            animator.SetFloat("Speed", move.magnitude);

            if (isInvincible)
            {
                invincibleTimer -= Time.deltaTime;
                if (invincibleTimer < 0)
                    isInvincible = false;
            }

        }
        
       
    }

    void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position;
        if(move)
        {
            if(left)
        {position.x = position.x + speed * horizontal * Time.deltaTime;
            position.y = position.y + speed * vertical * Time.deltaTime;

        }
        
        else
            position.x = position.x + speed * Math.Abs(horizontal) * Time.deltaTime;

        }
        
        

        rigidbody2d.MovePosition(position);
        if (animator.GetFloat("Speed") > 0 && music)
        {
            //PlaySound(walk);
            walk.SetActive(true);
        }
        else walk.SetActive(false);
        if (music && fai)
        {
            fail.SetActive(true);
        }
        else
            fail.SetActive(false);

        if (music && vict)
            victory.SetActive(true);
       
        

    }
    
}