using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlicingFood : MonoBehaviour
{
    //충돌 횟수
    public int sliceCount;

    //

    public List<GameObject> BreadSlice = new List<GameObject>();
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
        //충돌한 물체의 Tag가 Knife라면
        if (collision.gameObject.CompareTag("Knife"))
        {
            BreadSlice[sliceCount].transform.parent = null;
            BreadSlice[sliceCount].GetComponent<MeshCollider>().enabled = true;
            BreadSlice[sliceCount].GetComponent<Rigidbody>().isKinematic = false;
            //충돌횟수를 1회씩 증가
            sliceCount++;
          
        }


    }

}
