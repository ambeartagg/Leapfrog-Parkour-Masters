using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlatform : MonoBehaviour
{
     void OnCollisionEnter(Collision collision)
    {
        StartCoroutine("DestroyPlatformer");
    }

    IEnumerator DestroyPlatformer()
    {
        yield return new WaitForSeconds(2);
       Destroy(this.gameObject);
    }
}
