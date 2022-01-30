using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBOpening : MonoBehaviour
{
    Animator PlayAnimation;

    private void Start()
    {
        PlayAnimation = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayAnimation.SetBool("Trigger", true);
    }

}
