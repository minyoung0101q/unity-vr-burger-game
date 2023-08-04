using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steak : MonoBehaviour
{
    public List<Transform> steakList = new List<Transform>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SteakDown()
    {
        for (int i = 0; i < steakList.Count; i++)
        {
            steakList[i].transform.position = new Vector3(steakList[i].transform.position.x, steakList[i].transform.position.y - 0.007f, steakList[i].transform.position.z);
        }
    }
}
