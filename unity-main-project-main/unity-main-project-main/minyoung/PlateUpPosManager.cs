using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlateUpPosManager : MonoBehaviour
{

    public List<GameObject> upFoodList = new List<GameObject>();

    public Text test;
    public string result;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddFoodList(GameObject obj)
    {
        upFoodList.Add(obj);
        for(int i=0; i< upFoodList.Count; i++)
        {
            Debug.Log(i + "¹øÂ° :" + upFoodList[i].name);
            result = result + upFoodList[i].name;
        }
        Debug.Log("³¡");
        test.text = result;
    }

}
