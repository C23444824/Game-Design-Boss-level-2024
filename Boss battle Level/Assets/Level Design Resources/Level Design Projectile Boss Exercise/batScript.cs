using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(BoxCollider other)
    {
        transform.rotation = Quaternion.identity;
    }
    void Update()
    {
        
    }
}
