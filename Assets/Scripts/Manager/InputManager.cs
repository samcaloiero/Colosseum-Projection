using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    //Getting access to the EventManagerSO
    public EventManagerSO EventManagerSO;
    // All lettes used: oupai
    //Put this on Manager Empty
    void Update()
    {   //Checking for First Event Key
        if (Input.GetKeyDown(KeyCode.U))
        {
            Debug.Log("1 Pressed");
           EventManagerSO.event1 = true;
        }
        //Checking for Second Event Keya
        if (Input.GetKeyDown(KeyCode.I))
        {
            Debug.Log("2 Pressed");
            EventManagerSO.event2 =true;
        }
        //Checking for Third Event Key
        if (Input.GetKeyDown(KeyCode.O))
        {
            Debug.Log("3 Pressed");
            EventManagerSO.event3 = true;
        }
    }

    //Code to decide fate of "downed" gladiator
    private void LiveOrDie()
    {
        
    }
}
