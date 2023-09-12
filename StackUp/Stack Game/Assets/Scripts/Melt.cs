using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroyMe(7f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   IEnumerator DestroyMe(float waittime)
    {
        yield return new WaitForSeconds(waittime);
        Destroy(gameObject);
    }
}
