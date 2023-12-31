using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed;
    public Animator animator;
    public Rigidbody2D RB;
    private Vector2 movementDirection;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovements();
    }

    private void FixedUpdate() 
    {
        PlayerMovementInputs();  
    }

    void PlayerMovementInputs()

    {
        float xAxisMovement = Input.GetAxisRaw("Horizontal"); //Takes in the input of whether keys A or D have been pressed
        float yAxisMovement = Input.GetAxisRaw("Vertical"); //Takes in the input of whether keys W or S have been pressed

        if (xAxisMovement == -1)
        {
            animator.SetBool("FacingLeft", true);
        }

        else
        {
            animator.SetBool("FacingLeft", false);
        }

        animator.SetFloat("XAxisMovement", xAxisMovement);

        movementDirection = new Vector2(xAxisMovement, yAxisMovement).normalized; //Calculates the vector value of the axis inputs

    }
    void PlayerMovements()
    {
        RB.velocity = new Vector2(movementDirection.x * playerSpeed, movementDirection.y * playerSpeed); //Gives the player character velocity
    }
}
