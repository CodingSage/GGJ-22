using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class HMDInfoManager : MonoBehaviour
{

    public GameObject mockHMD;
    public GameObject locomotionSystem;

    public bool enableContinuousMovement;

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

        /*GameObject continuousMoveProvider = (GameObject) locomotionSystem.GetComponent<ActionBasedContinuousMoveProvider>();
        GameObject continuousTurnProvider = locomotionSystem.GetComponent<ActionBasedContinuousTurnProvider>();
        GameObject teleporationProvider = locomotionSystem.GetComponent<TeleportationProvider>();
        GameObject snapTurnProvider = locomotionSystem.GetComponent<ActionBasedSnapTurnProvider>();
        if (enableContinuousMovement)
        {
            continuousMoveProvider.SetActive(true);
        }
        else
        {

        }*/
    }

    void Update()
    {
        
    }
}
