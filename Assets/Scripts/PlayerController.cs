using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(HMDInfoManager))]
public class PlayerController : MonoBehaviour
{

    HMDInfoManager hmdManager;

    void Start()
    {
        hmdManager = GetComponent<HMDInfoManager>();
        hmdManager.EnableContinuousMovement(false);
    }

    void Update()
    {
        
    }
}
