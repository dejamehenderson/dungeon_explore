using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public float rotateSpeed = 5f; // A var to augment the rotation speed of this pickup

    public int pointValue = 1; // A var to store how many points this pickup is worth
    private void OnTriggerEnter (Collider other) // OnTriggerEnter() is called every time a collider marked as a trigger colllides with another collider
    {
        if (other.gameObject.CompareTag("Player")) // If the collider this pickup just hit is tagged as the Player...
        {
            Destroy(this.gameObject); //Destroy this pickup
            
            GameManager.Instance.UpdateScore(pointValue);

            GameManager.Instance.totalPickups -= 1; // Tell the gameManager to subtract
        }
    }

    private void Update()
    {
        // Every frame, make this pickup rotate
        transform.Rotate(new Vector3(15, 30, 45) * rotateSpeed * Time.deltaTime);
    }
}
