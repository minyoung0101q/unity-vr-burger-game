using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dish : MonoBehaviour
{
    public Transform upPos;
    // Start is called before the first frame update

    //public List<GameObject> foodList = new List<GameObject>();

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

    /*public void FoodAddOn(GameObject g)
    {
        if(!foodList.Contains(g))
        {
            foodList.Add(g);
        }
    }*/
    
}
