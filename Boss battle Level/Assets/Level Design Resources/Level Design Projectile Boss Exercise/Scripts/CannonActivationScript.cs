using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Events;

public class CannonActivationScr : MonoBehaviour
{
    public UnityEvent approachCannon, leaveCannon, interacted;
    public bool closeToCannon;
    public float timePressedDown;
    public bool CannonCompleted;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && CannonCompleted == false)
        {
            closeToCannon = true;
            approachCannon.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            closeToCannon = false;
            leaveCannon.Invoke();
        }
    }
    void Start()
    {
        closeToCannon = false;
        CannonCompleted = false;
        timePressedDown = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (CannonCompleted == false)
        {
            if (closeToCannon && Input.GetKey(KeyCode.E))
            {
                timePressedDown += Time.deltaTime;
                if (timePressedDown >= 3)
                {
                    CannonCompleted = true;
                    interacted.Invoke();
                }
            }
            else
            {
                timePressedDown = 0;
            }
        }
        
    }
}
