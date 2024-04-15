using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class SteamVRCustomInputs : MonoBehaviour
{
    public SteamVR_Action_Boolean myCustomActionBoolean;

    public SteamVR_Input_Sources handType;

    private void Start()
    {
        myCustomActionBoolean.AddOnStateDownListener(TriggerDown, handType);
        myCustomActionBoolean.AddOnStateUpListener(TriggerUp, handType);
    }

    public void TriggerUp(SteamVR_Action_Boolean fromAction,  SteamVR_Input_Sources fromSource)
    {
        Debug.Log("Up");
    }

    public void TriggerDown(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        Debug.Log("Down");
    }
}
