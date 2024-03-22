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
        
    }

    // Update is called once per frame
    void Update()
    {
        if (EventManagerSO.event1)
        {
            event1.SetActive(true);
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
