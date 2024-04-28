using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ProjectileRotation : MonoBehaviour
{

    public Vector3 projectileTransform;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        projectileTransform = transform.eulerAngles;
    }
}
