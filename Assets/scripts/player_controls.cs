using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class player_controls : MonoBehaviour
{
    public Rigidbody2D rb;
    public float move;
    public float movespeed = 0.1f;
        public float jumpheight = 1;
    Vector2 moveForward;
    public bool canGoForward = true;
    private bool grounded;
    public bool gravity;
    private Animator animator;
    Animator m_Animator;
    //private bool Jump;
   // public SpriteRenderer = Sprite;





    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // makes the player continuely go to the right
    void Update()
    {
       if (canGoForward == true)
        {
            moveForward = gameObject.transform.position;
           
            moveForward.x += movespeed * Time.deltaTime;
            gameObject.transform.position = moveForward;
        }
      


       //makes jumping infinitly impossible
        if (Input.GetButtonDown("Jump") && grounded == true)
        {
            
            

            rb.velocity += Vector2.up * jumpheight;
            grounded = false;
        }
        else if (Input.GetButton("Jump") && grounded == false)
        {
            
        }

        SetAnimations();

    }

    //resets jump stops movement when colliding with walls
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            grounded = true;
        }

        if (collision.gameObject.tag == "wall")
        {
            canGoForward = false;
            gravity = true;
            grounded = true;
           
            
        }
        else
        {
            canGoForward = true;
        }

       
    }

    private void Awake()
    {
        //animator.SetBool("movement", true);
        //animator.SetBool("jump", false);
        //animator.SetBool("still", false);
        animator = GetComponentInChildren<Animator>();


        SetAnimations();
    }


    void SetAnimations()
    {
        if (canGoForward == false)
        {
            animator.SetBool("Still", true);
        }
        else
        {
            animator.SetBool("Still", false);
        }


        if (grounded == false)
        {
            animator.SetBool("Jump", true);
        }
        else
        {
            animator.SetBool("Jump", false);
        }
    }







}
