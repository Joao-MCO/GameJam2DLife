using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ana : MonoBehaviour
{
    private Animator anim;
    private int fator = -1;
    public int speed;
    private SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float y = 0, x = 0;
        if(transform.position.y > 0){
            y = fator*speed*Time.deltaTime;
            anim.SetInteger("Direction", 0);
            movimento(0f, y);
        }
        if(transform.position.y == 0){
            y = 0;
        }
        if(transform.position.x > 2.4f && y==0){
            x = fator*speed*Time.deltaTime;
            anim.SetInteger("Direction", 2);
            if(!sr.flipX){    
                sr.flipX = true;
            }

            movimento(x, 0f);

        }
        anim.SetBool("Andando", (y+x)!=0);
        if(!anim.GetBool("Andando")){
            sr.flipX = false;
        }
    }

    private void movimento(float x, float y){
        Vector3 movimento = new Vector3(x, y, 0f);
        transform.position += movimento;
    }
}
