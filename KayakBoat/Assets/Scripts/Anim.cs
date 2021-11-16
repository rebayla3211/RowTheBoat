using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim : MonoBehaviour
{
    public Animator animleft;
    public Animator animright;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            animleft.SetInteger("PaddleLeft" , 1);
            animright.SetInteger("PaddleRight" , 1);
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            animleft.SetInteger("PaddleLeft", 0);
            animright.SetInteger("PaddleRight" , 0);
        }
    }
}
