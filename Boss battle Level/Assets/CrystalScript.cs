using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalScript : MonoBehaviour
{
    public Material activatedMaterial;
    public GameObject lowerHalf;
    private bool crystalTriggered;
    // Start is called before the first frame update
    void Start()
    {
        crystalTriggered = false;
    }

    private void OnTriggerEnter(Collider collider)
    {
        GetComponent<Renderer>().material = activatedMaterial;
        lowerHalf.GetComponent<Renderer>().material = activatedMaterial;
        crystalTriggered = true;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
