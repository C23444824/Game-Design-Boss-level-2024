using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    public float selfDestructTimer;
    // Start is called before the first frame update
    void Start()
    {
        //starts self destruct coroutine
        StartCoroutine(SelfDestructTimer());
    }

    IEnumerator SelfDestructTimer()
    {
        //waits for selfDestructTimer seconds
        yield return new WaitForSeconds(selfDestructTimer);
        //destroys the game object
        Destroy(gameObject);
    }
}
