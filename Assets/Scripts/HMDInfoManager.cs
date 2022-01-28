using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HMDInfoManager : MonoBehaviour
{

    public GameObject mockHMD;

    void Start()
    {
        if(!XRSettings.isDeviceActive)
        {
            Debug.Log("No headset detected");
        }
        else if(XRSettings.isDeviceActive && !(XRSettings.loadedDeviceName == "Mock HMD" || XRSettings.loadedDeviceName == "MockHMD Display"))
        {
            Debug.Log("Headset detected : " + XRSettings.loadedDeviceName);
            mockHMD.SetActive(false);
        }
        else
        {
            Debug.Log("Mock HMD active");
        }
    }

    void Update()
    {
        
    }
}
