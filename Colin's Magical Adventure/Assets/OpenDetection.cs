﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDetection : MonoBehaviour
{
    BoxCollider boxCollider;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider>();
        animator = GetComponentInChildren<Animator>();
        //animation = GetComponentInChildren<Q>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other){

        //Debug.Log(animator);
        if(other.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Key a down");
                /*animation.Play("OpenDoor");
                isAnimated = true;*/
                animator.SetBool("isOpen", true);
            }
                

            //Debug.Log("collision with player");
        }

    }

    void OnTriggerExit(Collider other)
    {
        GameObject newNeighbor = other.GetComponent<CapsuleCollider>().gameObject;
        if (newNeighbor.tag == "Player")
        {
            animator.SetBool("isOpen", false);
        }
    }
}
