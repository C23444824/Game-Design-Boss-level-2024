using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public GameObject crystal1;
    private CrystalScript crystal1script;
    public GameObject crystal2;
    private CrystalScript crystal2script;
    public GameObject crystal3;
    private CrystalScript crystal3script;
    void Start()
    {
        crystal1script = crystal1.GetComponent<CrystalScript>();
        crystal2script = crystal2.GetComponent<CrystalScript>();
        crystal3script = crystal3.GetComponent<CrystalScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((crystal1script.crystalTriggered) && (crystal2script.crystalTriggered) && (crystal3script.crystalTriggered)) 
        {
            gameObject.transform.position = Vector3.down * 20;
        }
    }
}
