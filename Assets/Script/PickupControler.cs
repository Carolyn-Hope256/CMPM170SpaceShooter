using System;
using UnityEngine;

public class PickupControler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("colliding");
        PlayerController unit = other.GetComponent<PlayerController>();
        if (unit != null)
        {
            unit.fire_delay *= (float).8;
            Destroy(gameObject);
        }
    }
}

