using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cs : MonoBehaviour
{
    public GameObject zombieW;
    Animator anim;

    private void Start()
    {
        anim = zombieW.GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        anim.SetFloat("speed", ver);
        anim.SetFloat("direction", hor);


     
    }
}
