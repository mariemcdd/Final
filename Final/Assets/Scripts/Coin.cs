using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))

        {
            Debug.Log("Player collected the coin.");
            Destroy(this.gameObject);
        }
    }
}
  
