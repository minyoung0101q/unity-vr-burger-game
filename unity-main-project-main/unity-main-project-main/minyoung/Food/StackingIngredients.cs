using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackingIngredients : MonoBehaviour
{
    //충돌 횟수
    public int crashCount;

  
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
        //충돌한 물체의 Tag가 Plate라면
        if (collision.gameObject.CompareTag("Plate"))
        {
            /*BreadSlice[sliceCount].transform.parent = null;
            BreadSlice[sliceCount].GetComponent<MeshCollider>().enabled = true;*/
            //this.transform.parent = collision.gameObject.transform;
            //collision.gameObject.SendMessage("ShowBread");
            Destroy(gameObject);
            
          
            //this.GetComponent<Rigidbody>().isKinematic = true;

            //충돌횟수를 1회씩 증가
            //crashCount++;
        }
    }
}
