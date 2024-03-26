using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public EventManagerSO EventManagerSO;
    //Getting empties which hold each events media
    public GameObject event1;
    public GameObject event2;
    public GameObject event3;
    //Getting animations for event3's decisions
    public GameObject liveAnim;
    public GameObject dieAnim;
    //bool for restarting scene coroutine
    private bool coroutineStarted = false;
    void Start()
    {
        ResetScene();
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

        if (EventManagerSO.die)
        {
            DieSequence();
        }

        if (EventManagerSO.live)
        {
            LiveSequence();
        }
    }

    

    public void ResetScene()
    {
        coroutineStarted = false;
        EventManagerSO.event1 = false;
        event1.SetActive(false);
        EventManagerSO.event2 = false;
        event2.SetActive(false);
        EventManagerSO.event3 = false;
        event3.SetActive(false);
        //Setting animations to false on start/reset
        liveAnim.SetActive(false);
        dieAnim.SetActive(false);
        //Setting live or die values to false
        EventManagerSO.live = false;
        EventManagerSO.die = false;
    }
    private void DieSequence()
    {
       dieAnim.SetActive(true);
       //Call Coroutine
       StartCoroutine(RestartSceneCoroutine());

    }
    private void LiveSequence()
    {
        liveAnim.SetActive(true);
        StartCoroutine(RestartSceneCoroutine());
    }

    private IEnumerator RestartSceneCoroutine()
    {
        Debug.Log("Coroutine called");
        if (coroutineStarted == false)
        {
            coroutineStarted = true;
            yield return new WaitForSeconds(5f);
            ResetScene();
            
        }
    }
}
