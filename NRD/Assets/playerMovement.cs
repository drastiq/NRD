using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {


    public float playerSpeed;
    Rigidbody2D playerRigidbody;
    
    bool isRight = true;



    void Start ()
    {
        playerRigidbody = GetComponent <Rigidbody2D> ();
	}
	
    


	void FixedUpdate ()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");


        playerRigidbody.velocity = new Vector3(horizontal * playerSpeed, vertical *playerSpeed, 0);
        if (horizontal > 0 && !isRight)
        {
            Flip();
        }
        else if (horizontal < 0 && isRight)
        {
            Flip();
        }

    }



    void Flip()
    {
        isRight = !isRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
