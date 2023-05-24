using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eduardo : MonoBehaviour
{
    private Animator animator;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        CharMovement();
    }

    void CharMovement(){
        Vector3 dir = Vector3.zero;
        if (Input.GetKey(KeyCode.A)){
            dir.x = -1;
            animator.SetInteger("Direction", 2);
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
        }
        else if (Input.GetKey(KeyCode.D)){
            dir.x = 1;
            animator.SetInteger("Direction", 2);
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.W)){
            dir.y = 1;
            animator.SetInteger("Direction", 1);
        }
        else if (Input.GetKey(KeyCode.S)){
            dir.y = -1;
            animator.SetInteger("Direction", 0);
        }

        animator.SetBool("Andando", dir.magnitude > 0);
        transform.position += dir*speed*Time.deltaTime;
    }
}
