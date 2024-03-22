using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public EventManagerSO EventManagerSO;
    public GameObject event1;
    public GameObject event2;
    public GameObject event3;
    void Start()
    {
        //Setting Events False on Awaken
        EventManagerSO.event1 = false;
        EventManagerSO.event2 = false;
        EventManagerSO.event3 = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Checking to see if each event is set to true, at which point sequence begins
        if (EventManagerSO.event1)
        {
            //Debug.Log("Setting Active Event 1");
            event1.SetActive(true);
            //EventManagerSO.event1 = false;
        }
        if (EventManagerSO.event2)
        {
            event2.SetActive(true);
        }
        if (EventManagerSO.event3)
        {
            event3.SetActive(true);
        }
    }
}
