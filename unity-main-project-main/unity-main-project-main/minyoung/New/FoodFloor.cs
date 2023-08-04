using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodFloor : MonoBehaviour
{
    public enum FloorState
    {
        Dish, Food
    }
    public FloorState floorState = FloorState.Dish;

    public Transform upPos;

    public enum FoodStep
    {
        None, Ready, FoodOn
    }
    public FoodStep foodStep = FoodStep.None;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        switch(floorState)
        {
            case FloorState.Dish:
                {
                    switch(foodStep)
                    {
                        case FoodStep.Ready:
                            {
                                if (collision.transform.CompareTag("Food"))
                                {
                                    collision.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
                                    collision.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
                                    collision.gameObject.GetComponent<Rigidbody>().isKinematic = true;
                                    collision.transform.parent = upPos.transform;
                                    collision.transform.position = upPos.position;
                                    collision.transform.rotation = upPos.rotation;
                                    collision.gameObject.GetComponent<Collider>().isTrigger = true;
                                    collision.gameObject.GetComponent<FoodFloor>().foodStep = FoodStep.Ready;
                                    Debug.Log(collision.gameObject.GetComponent<FoodFloor>().foodStep);
                                    foodStep = FoodStep.FoodOn;
                                }
                                break;
                            }
                    }
                    break;
                }
            case FloorState.Food:
                {
                    switch(foodStep)
                    {
                        case FoodStep.Ready:
                            {
                                if (collision.transform.CompareTag("Food"))
                                {
                                    collision.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
                                    collision.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
                                    if (!collision.gameObject.GetComponent<Rigidbody>().isKinematic)
                                    {
                                        collision.gameObject.GetComponent<Rigidbody>().isKinematic = true;
                                        collision.transform.parent = upPos.transform;
                                        collision.transform.position = upPos.position;
                                        collision.transform.rotation = upPos.rotation;
                                        

                                        collision.gameObject.GetComponent<FoodFloor>().foodStep = FoodStep.Ready;
                                    }
                                    Debug.Log(collision.gameObject.GetComponent<FoodFloor>().foodStep);
                                    foodStep = FoodStep.FoodOn;
                                }
                                    break;
                            }
                    }
                    break;
                }
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        switch (floorState)
        {
            case FloorState.Food: 
                {
                    switch (foodStep)
                    {
                        case FoodStep.Ready:
                            {
                                if (other.transform.CompareTag("Food"))
                                {
                                    other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
                                    other.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
                                    if (!other.gameObject.GetComponent<Rigidbody>().isKinematic)
                                    {
                                        other.gameObject.GetComponent<Rigidbody>().isKinematic = true;
                                        other.transform.parent = upPos.transform;
                                        other.transform.position = upPos.position;
                                        other.transform.rotation = upPos.rotation;


                                        other.gameObject.GetComponent<FoodFloor>().foodStep = FoodStep.Ready;
                                    }
                                    Debug.Log(other.gameObject.GetComponent<FoodFloor>().foodStep);
                                    foodStep = FoodStep.FoodOn;
                                }
                                break;
                            }
                    }
                    break;
                }

        }     
    }
}
