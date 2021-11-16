using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetBool("New Bool" , true);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetBool("New Bool", false);
        }
    }
}
