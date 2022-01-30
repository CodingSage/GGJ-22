using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class HMDInfoManager : MonoBehaviour
{

    public GameObject mockHMD;
    public GameObject locomotionSystem;

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

    public void EnableContinuousMovement(bool enableContinuousMovement)
    {
        ActionBasedContinuousMoveProvider continuousMoveProvider = locomotionSystem.GetComponent<ActionBasedContinuousMoveProvider>();
        ActionBasedContinuousTurnProvider continuousTurnProvider = locomotionSystem.GetComponent<ActionBasedContinuousTurnProvider>();
        TeleportationProvider teleporationProvider = locomotionSystem.GetComponent<TeleportationProvider>();
        ActionBasedSnapTurnProvider snapTurnProvider = locomotionSystem.GetComponent<ActionBasedSnapTurnProvider>();

        continuousMoveProvider.enabled = enableContinuousMovement;
        continuousTurnProvider.enabled = enableContinuousMovement;
        teleporationProvider.enabled = !enableContinuousMovement;
        snapTurnProvider.enabled = !enableContinuousMovement;
    }

    void Update()
    {
        
    }
}
