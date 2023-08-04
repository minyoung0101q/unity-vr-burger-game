using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodContainer : MonoBehaviour
{
    /*public string foodname;
    public string foodCode;*/
    


    /*public List<GameObject> upFoodList = new List<GameObject>();
    public string result;
    public Text test;*/
    public enum ContainerState
    {
        None, Ready, ContainerOn
    }
    public ContainerState containerState = ContainerState.None;

    public PlateUpPosManager plateupPos;
    
    bool isDish = false;

    bool collsign = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
    public void OnCollisionEnter(Collision collision)
    {
        switch(containerState)
        {
            case ContainerState.Ready:
                {
                    if (collision.gameObject.CompareTag("Food"))
                    {
                        //if(collsign)
                        {
                            collision.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
                            collision.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
                            collision.gameObject.SendMessage("ContainerReadyOn");
                            if (!collision.gameObject.GetComponent<Rigidbody>().isKinematic)
                            {
                                Debug.Log("재료 올리기");
                                this.SendMessage("UpFood", collision.gameObject);
                            }
                            plateupPos.AddFoodList(collision.gameObject);
                            collision.gameObject.GetComponent<AudioSource>().Play();
                            /*containerState = ContainerState.ContainerOn;

                            *//*foodCode += collision.gameObject.GetComponent<FoodContainer>().foodname;

                            test.text = foodCode;*//*

                            upFoodList.Add(collision.gameObject);

                            for (int i = 0; i < upFoodList.Count; i++) {
                                result = result + upFoodList[i].name;
                            }
                            Debug.Log(collision.gameObject.transform.name);
                            if(collision.gameObject.GetComponent<Food>().parentDish)
                            {
                                Debug.Log("접시등록함?");
                                this.SendMessage("SecondFoodDishOn", collision.transform.gameObject);
                            }

                            test.text = result;*/
                            //collsign = false;
                        }

                    }

                    /*if(collision.gameObject.transform.CompareTag("Plate"))
                    {
                        this.SendMessage("DishParentOn", collision.transform);
                    }*/
                    
                    break;
                }
        }
    }

    public void ContainerReadyOn()
    {
        switch(containerState)
        {
            case ContainerState.None:
                {
                    containerState = ContainerState.Ready;
                    break;
                }
        }
    }
}
