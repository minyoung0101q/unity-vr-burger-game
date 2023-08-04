using System.Collections;
using UnityEngine;

public class Dish : MonoBehaviour
{
    public Transform upPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpFood(GameObject food)
    {
        food.transform.parent = upPos;
        food.transform.position = upPos.position;
        food.transform.rotation = upPos.rotation;
        food.GetComponent<Rigidbody>().isKinematic = true;
        //food.GetComponent<Collider>().isTrigger = true;
    }
    
}
