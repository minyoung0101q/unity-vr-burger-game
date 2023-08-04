using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sausage : MonoBehaviour
{
    public List<Transform> sausageList = new List<Transform>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SausageDown()
    {
        for (int i = 0; i < sausageList.Count; i++)
        {
            sausageList[i].transform.position = new Vector3(sausageList[i].transform.position.x, sausageList[i].transform.position.y - 0.007f, sausageList[i].transform.position.z);
        }
    }
}
