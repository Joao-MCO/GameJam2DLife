using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ana : MonoBehaviour
{
    private Animator anim;
    private int fator = -1;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float y = 0;
        if(transform.position.y > 0){
            y = fator*speed*Time.deltaTime;
            anim.SetInteger("Direction", 0);
            movimento(y);
        }
        if(transform.position.y == 0){
            y = 0;
            // Dialogo
        }
        anim.SetBool("Andando", y!=0);
    }

    private void movimento(float y){
        Vector3 movimento = new Vector3(0f, y, 0f);
        transform.position += movimento;
    }
}
