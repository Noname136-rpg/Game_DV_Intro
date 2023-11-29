using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSprite : MonoBehaviour
{
    private bool pDirection = true; //true면 오른쪽
    private int directionSign = 1;
    public GameObject MainPlayer;
    public new Vector3 prevVec = new Vector3(0, 0, 0);
    public Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MainPlayer.transform.position == prevVec)
        {
            ani.SetBool("IsWalking", false);
        }
        else
        {
            ani.SetBool("IsWalking", true);
        }

        chooseDirectionbyMP();

        prevVec = MainPlayer.transform.position;
    }

    private void chooseDirectionbyMP()
    {
        Vector3 MousePoint = Input.mousePosition;
        Vector3 MousePointWorld = Camera.main.ScreenToWorldPoint(MousePoint);

        Vector3 PlayerPosition = this.transform.position;

        if (PlayerPosition.x > MousePointWorld.x)
        {
            pDirection = false;
            transform.rotation = Quaternion.Euler(0, 180, 0);

        }
        if (PlayerPosition.x < MousePointWorld.x)
        {
            pDirection = true;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        Debug.Log(MousePoint);
        Debug.Log(MousePointWorld);
    }
}
