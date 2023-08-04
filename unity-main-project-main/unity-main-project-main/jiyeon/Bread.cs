using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bread : MonoBehaviour
{
    public Transform upPos;
    public List<Transform> breadList = new List<Transform>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BreadDown()
    {
        for(int i = 0; i < breadList.Count; i++)
        {
            breadList[i].transform.position = new Vector3(breadList[i].transform.position.x, breadList[i].transform.position.y - 0.007f, breadList[i].transform.position.z);
        }
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
