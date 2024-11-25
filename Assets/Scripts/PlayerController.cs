using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour

{
    private Rigidbody2D characterRigidbody;

    public static Animator characterAnimator;

    private float horizontalInput;

    [SerializeField]private float characterSpeed = 4.5f;
    [SerializeField]private float jumpForce = 10;
    

    void Awake()
    {
        characterRigidbody = GetComponent<Rigidbody2D>();
        characterAnimator = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
    
    }

    void Update()
    {
        Movement();
      
        if(Input.GetButtonDown("Jump") && GroundSensor.isGrounded)
        {
            Jump();
        }


    }

    void FixedUpdate()
    {
            characterRigidbody.velocity = new Vector2(horizontalInput * characterSpeed, characterRigidbody.velocity.y);

    }
  
    
    
    
     void Movement()
    {
          horizontalInput = Input.GetAxis("Horizontal");

        if(horizontalInput < 0)
        {
            
            
                 transform.rotation = Quaternion.Euler(0, 180, 0);
            
           
            characterAnimator.SetBool("IsRunning", true);
        }

        else if(horizontalInput > 0)
        {
            
                 transform.rotation = Quaternion.Euler(0, 0, 0);
            
           
            characterAnimator.SetBool("IsRunning", true);
        }

        else
        {
            characterAnimator.SetBool("IsRunning", false);
        }
       
    }

    void Jump()
    {
        characterRigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        characterAnimator.SetBool("IsJumping", true);

    }
    

   
}
