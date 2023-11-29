using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int playerInitSpeed = 10;
   

    //Vector3 MousePoint = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z));
    // Start is called before the first frame update
    void Start()
    {
        
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
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, -playerInitSpeed * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-1*playerInitSpeed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(1*playerInitSpeed * Time.deltaTime, 0, 0));
        }
    }

    
}
