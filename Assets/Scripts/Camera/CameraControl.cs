using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform heroPos;

    private Vector3 offset;

    private Vector3 v = Vector3.zero;

    private Vector3 plus = Vector3.zero;

    public GameObject hero;

    // Use this for initialization
    void Start()
    {
        offset = transform.position - heroPos.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }
    

    private void move()
    {
        
        plus = Vector3.zero;
        if (hero.GetComponent<PlayerControl>().horizontalMove > 0)
            plus += new Vector3(0.5f, 0, 0);
        if (hero.GetComponent<PlayerControl>().horizontalMove < 0)
            plus += new Vector3(-0.5f, 0, 0);
        if (hero.GetComponent<PlayerControl>().verticalMove > 0)
            plus += new Vector3(0, 0.5f, 0);
        if (hero.GetComponent<PlayerControl>().verticalMove < 0)
            plus += new Vector3(0, -0.5f, 0);

        transform.position = Vector3.Lerp(transform.position, offset + heroPos.position + plus, 0.05f);
    }
}
