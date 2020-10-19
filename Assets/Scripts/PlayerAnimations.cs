using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    Animator anim;

    Vector3 PrevPos;
    Vector3 NewPos;
    Vector3 ObjVelocity;
    // Start is called before the first frame update
    private void Awake()
    {
        anim = transform.GetChild(1).GetComponent<Animator>();
    }

    void Start()
    {
        PrevPos = transform.position;
        NewPos = transform.position;
    }

    void FixedUpdate()
    {
        NewPos = transform.position;  // each frame track the new position
        ObjVelocity = (NewPos - PrevPos) / Time.fixedDeltaTime;  // velocity = dist/time
        PrevPos = NewPos;  // update position for next frame calculation
        Debug.Log(ObjVelocity);

        anim.SetFloat("Speed", Mathf.Abs(ObjVelocity.x));
    }
}
