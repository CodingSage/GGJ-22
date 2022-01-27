using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HMDInfoManager : MonoBehaviour
{
    void Start()
    {
        if(!XRSettings.isDeviceActive)
        {
            Debug.Log("No headset detected");
        }
        else if(XRSettings.isDeviceActive && (XRSettings.loadedDeviceName == "Mock HMD" || XRSettings.loadedDeviceName == "MockHMD Display"))
        {
            Debug.Log("Mock HMD active");
        }
        else
        {
            Debug.Log("Headset detected : " + XRSettings.loadedDeviceName);
            // maybe disable mock objects
        }
    }

    void Update()
    {
        
    }
}
