using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HMDInfoManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (!XRSettings.isDeviceActive)
        {
            Debug.Log("No Headest");
        }
        else if (XRSettings.isDeviceActive && (XRSettings.loadedDeviceName == "Mock HMD") || (XRSettings.loadedDeviceName == "MockHMDDisplay"))
        {
            Debug.Log("Active headset " + XRSettings.loadedDeviceName);
        }
        else
        {
            Debug.Log("Active headset " + XRSettings.loadedDeviceName);
        }
    }

 
}
