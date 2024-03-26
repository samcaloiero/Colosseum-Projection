using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    //Getting access to the EventManagerSO
    public EventManagerSO EventManagerSO;
    // All lettes used: oupai
    //UIOPA
    //(1,2,3,Lpa,R) in order
    //Put this on Manager Empty
    void Update()
    {   //Checking for First Event Key
        if (Input.GetKeyDown(KeyCode.U))
        {
            Debug.Log("1 Pressed");
           EventManagerSO.event1 = true;
        }

        if (EventManagerSO.event1)
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                Debug.Log("2 Pressed");
                EventManagerSO.event2 =true;
            }  
        }

        if (EventManagerSO.event2)
        {
            //Checking for Third Event Key
            if (Input.GetKeyDown(KeyCode.O))
            {
                Debug.Log("3 Pressed");
                EventManagerSO.event3 = true;
            } 
        }
        if (EventManagerSO.event3)
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                Debug.Log("3 Pressed");
                EventManagerSO.live = true;
                //This is so user can't click both options
                EventManagerSO.event3 = false;
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                Debug.Log("3 Pressed");
                EventManagerSO.die = true;
                //This is so user can't click both options
                EventManagerSO.event3 = false;
            } 
        }
        
    }

    //Code to decide fate of "downed" gladiator
    private void LiveOrDie()
    {
        
    }
}
