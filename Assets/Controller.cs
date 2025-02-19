using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float y,x;
        y = Input.GetAxis("Vertical");
        x = Input.GetAxis("Horizontal");
        animator.SetFloat("Blend", y);
        animator.SetFloat("Turn", x);


    }
}
