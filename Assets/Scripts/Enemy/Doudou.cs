using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doudou : MonoBehaviour
{
    public GameObject player;
    //仇恨范围
    public float scopeOfHatred;
    //移动速度
    public float moveSpeed;

    public Animator animator;

    private bool direction=true;
    private bool tempDiraction = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Hunt();
    }

    private void Hunt()
    {
        if (Vector3.Distance(player.transform.position, gameObject.transform.position) < scopeOfHatred)
        {
            animator.SetBool("Move", true);
            Vector3 dir = (player.transform.position - transform.position).normalized;
            if(dir.x<0)
            {
                animator.SetBool("Direction", true);
            }
            else
            {
                animator.SetBool("Direction", false);
            }
            transform.Translate(dir * moveSpeed * Time.deltaTime);
        }
        else
        {
            animator.SetBool("Move", false);
        }
    }
}
