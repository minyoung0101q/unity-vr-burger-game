using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bread : MonoBehaviour
{
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
}
