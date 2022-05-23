using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public string eventName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            CustomEvent.Trigger(collision.gameObject, eventName, gameObject);
        }
    }
}
    
   
