using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCharacterController : MonoBehaviour
{
    public float Speed;
    public CharacterController player;
    float gravity = -15.81f;
    public float highJump;
    public UIPosition uiPosition;
    public Animator legs, hands;

    public Transform groundedCheck;
    public float groundDistance;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    void Start()
    {
        uiPosition = this.gameObject.GetComponent<UIPosition>();
    }
    void Update()
    {
            PlayerMovement();
            Sprint();
            Jump();
    }
    void Sprint()
    {
        if(player.isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                Speed = 6;
            }
            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                Speed = 4;
            }
        }
       

    }

    void PlayerMovement()
    {
        

        isGrounded = Physics.CheckSphere(groundedCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -3f;
        }


        if (uiPosition.inventoryActive == false)
        {
            float hor = Input.GetAxis("Horizontal");
            float ver = Input.GetAxis("Vertical");

            Vector3 move = Camera.main.transform.right * hor + transform.forward * ver;

            player.Move(move * Speed * Time.deltaTime);

        }

        velocity.y += gravity * Time.deltaTime * 1.5f;

        player.Move(velocity * Time.deltaTime);


       

        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            legs.SetBool("ruch", true);
            hands.SetBool("ruch", true);
        }
        else
        {
            legs.SetBool("ruch", false);
            hands.SetBool("ruch", false);
        }

  
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            hands.SetBool("Jump", true);
            legs.SetBool("Jump", true);
            velocity.y = Mathf.Sqrt(highJump * -2f * gravity);
        }
        else
        {
            hands.SetBool("Jump", false);
            legs.SetBool("Jump", false);
        }
    }

  
}
