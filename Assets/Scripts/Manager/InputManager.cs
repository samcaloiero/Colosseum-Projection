using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    //Getting access to the EventManagerSO
    public EventManagerSO EventManagerSO;

    //Put this on Manager Empty
    void Update()
    {   //Checking for First Event Key
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            Debug.Log("1 Pressed");
           EventManagerSO.event1 = true;
        }
        //Checking for Second Event Key
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            Debug.Log("2 Pressed");
            EventManagerSO.event2 =true;
        }
        //Checking for Third Event Key
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            Debug.Log("3 Pressed");
            EventManagerSO.event3 = true;
        }
    }


    private void LiveOrDie()
    {
        
    }
}
