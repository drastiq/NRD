using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour
{


    public float playerSpeed;
    Rigidbody2D playerRigidbody;
    float playerVelocity;


    private Animator animacja;

    void Start()
    {
        animacja = GetComponent<Animator>();
        playerRigidbody = GetComponent<Rigidbody2D>();

    }




    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");


        playerRigidbody.velocity = new Vector3(horizontal * playerSpeed, vertical * playerSpeed, 0);
        AnimController();

    }




    void AnimController()
    {


        //UP
        if (Input.GetKey(KeyCode.UpArrow))
        {
            animacja.SetBool("idleUp", true);
            animacja.SetBool("idleDown", false);
            animacja.SetBool("idleLeft", false);
            animacja.SetBool("idleRight", false);
        }

        //DOWN
        if (Input.GetKey(KeyCode.DownArrow))
        {
            animacja.SetBool("idleUp", false);
            animacja.SetBool("idleDown", true);
            animacja.SetBool("idleLeft", false);
            animacja.SetBool("idleRight", false);
        }

        //LEFT
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            animacja.SetBool("idleUp", false);
            animacja.SetBool("idleDown", false);
            animacja.SetBool("idleLeft", true);
            animacja.SetBool("idleRight", false);
        }

        //RIGHT
        if (Input.GetKey(KeyCode.RightArrow))
        {
            animacja.SetBool("idleUp", false);
            animacja.SetBool("idleDown", false);
            animacja.SetBool("idleLeft", false);
            animacja.SetBool("idleRight", true);
        }





        //UP
        if (Input.GetKey(KeyCode.UpArrow))
        {

            animacja.SetBool("walkingUp", true);

        }
        else
        {
            animacja.SetBool("walkingUp", false);


        }

        //DOWN
        if (Input.GetKey(KeyCode.DownArrow))
        {

            animacja.SetBool("walkingDown", true);

        }
        else
        {
            animacja.SetBool("walkingDown", false);


            //LEFT
            if (Input.GetKey(KeyCode.LeftArrow))
            {

                animacja.SetBool("walkingLeft", true);

            }
            else
            {
                animacja.SetBool("walkingLeft", false);


            }

            //RIGHT
            if (Input.GetKey(KeyCode.RightArrow))
            {

                animacja.SetBool("walkingRight", true);
            }
            else
            {

                animacja.SetBool("walkingRight", false);

            }
        }



    }
}