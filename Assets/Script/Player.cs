using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int playerInitSpeed = 10;
    public Rigidbody2D rigid;
    private float MaxVelocity = 7f;
    private float initVelocity = 5f;
    private float CurrentVelocity = 5f;


    //Vector3 MousePoint = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z));
    // Start is called before the first frame update
    void Start()
    {
        CurrentVelocity = initVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        getKeytoMove();
    }

    private void getKeytoMove()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, playerInitSpeed * Time.deltaTime, 0));
            //rigid.AddForce(Vector3.up * CurrentVelocity);
            //rigid.velocity = new Vector2(rigid.velocity.x, MaxVelocity);
        }
        
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, -playerInitSpeed * Time.deltaTime, 0));
            //rigid.AddForce(Vector3.down * CurrentVelocity);
            //rigid.velocity = new Vector2(rigid.velocity.x, (-1)*MaxVelocity);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-1*playerInitSpeed * Time.deltaTime, 0, 0));
            //rigid.AddForce(Vector3.left * CurrentVelocity);
            //rigid.velocity = new Vector2((-1) * MaxVelocity, rigid.velocity.y);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(1*playerInitSpeed * Time.deltaTime, 0, 0));
            //rigid.AddForce(Vector3.right * CurrentVelocity);
            //igid.velocity = new Vector2(MaxVelocity, rigid.velocity.y);
        }
        //이동 방식의 종류
        //1. rigidBody로 이동하는 법
        //2. transform을 만져서 이동하는 법
        //등등
    }

    private void limitVelocity()
    {
        if(rigid.velocity.x > MaxVelocity)
        {
            //rigid.
        }
        else if (rigid.velocity.x > MaxVelocity)
        {

        }

        if (rigid.velocity.y > MaxVelocity)
        {

        }
        else if (rigid.velocity.y > MaxVelocity)
        {

        }
    }
}
