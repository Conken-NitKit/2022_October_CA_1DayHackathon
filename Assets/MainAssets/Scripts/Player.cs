using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float runSpeed;
    [SerializeField]
    private float climbSpeed;
    [SerializeField]
    private float jumpForce;
    [SerializeField]
    private Rigidbody2D rigidbody;

    [SerializeField]
    private GameObject shuriken;
    [SerializeField]
    private int remainShurikenNumber;

    [SerializeField]
    private LayerMask ladderLayer;

    /*private string rightMoveKey;
    private string leftMoveKey;
    private string jumpKey;
    private string climbKey;
    private string attackKey;*/

    private float xSpeed = 0;
    private float ySpeed = 0;
    private float neutralSpeed = 0;
    private float gravity = 1;

    private bool isLadder;
    private bool isGround;
    private float laycastDistanse =  1f;
    private int defaultGravityScale = 1;
    private int ladderGravityScale = 0;


    
    private void throwShuriken()
    {
        remainShurikenNumber--;
        Instantiate(shuriken,transform.position,transform.rotation);
    }

    // Start is called before the first frame update
    void Start()
    {
        isLadder = false;
        isGround = false;
    }

    // Update is called once per frame
    void Update()
    {
        ySpeed = -gravity;
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position,Vector2.up,laycastDistanse,ladderLayer);
        if(hitInfo.collider != null)
        {
            isLadder = true;
            gravity = ladderGravityScale;
        }else{
            isLadder = false;
            gravity = defaultGravityScale;
        }

        if(Input.GetKey(/*rightMoveKey*/KeyCode.D))
        {
            xSpeed = runSpeed;  
        }else if(Input.GetKey(/*leftMoveKey*/KeyCode.A)){
            xSpeed = -runSpeed;
        }else
        {
            xSpeed = neutralSpeed;
        }

        if(Input.GetKey(/*climbKey*/KeyCode.W) && isLadder)
        {
            ySpeed = climbSpeed;
        }
        
        if(isGround){
            if(Input.GetKeyDown(/*jumpKey*/KeyCode.R)){
                rigidbody.AddForce(new Vector2(0f,jumpForce));
            }
        }
        

        if(Input.GetKey(/*attackKey*/KeyCode.S) && remainShurikenNumber > 0)
        {
            throwShuriken();
        }

        rigidbody.velocity = new Vector2(xSpeed,ySpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("testground"))
        {
            isGround = true;
        }
    }


    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("testground"))
        {
            isGround = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("testground"))
        {
            isGround = false;
        }
    }
}
