using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    //public Transform parentDish;
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

        /*switch (this.transform.name)
        {
            case "Bread":
                {
                    this.SendMessage("BreadDown");
                    break;
                }
            case "Steak":
                {
                    this.SendMessage("SteakDown");
                    break;
                }
            case "Sausage":
                {
                    this.SendMessage("SausageDown");
                    break;
                }
        }*/
    }

    /*public void DishParentOn(Transform t)
    {
        if(!parentDish)
        {
            parentDish = t;
        }
        parentDish.SendMessage("FoodAddOn", gameObject);
    }

    public void SecondFoodDishOn(GameObject g)
    {
        Debug.Log(g.transform.name);
        parentDish = g.GetComponent<Food>().parentDish;
        parentDish.SendMessage("FoodAddOn", gameObject);
    }*/
}
