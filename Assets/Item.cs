using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string itemName;

    private void OnCollisionEnter(Collision col)
    {
        if (col.transform.CompareTag("Player"))
        {
            col.transform.GetComponent<Inventory>().items.Add(itemName);
            Destroy(this.gameObject);
        }
    }
}
