using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackingIngredients : MonoBehaviour
{
    //�浹 Ƚ��
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
        //�浹�� ��ü�� Tag�� Plate���
        if (collision.gameObject.CompareTag("Plate"))
        {
            /*BreadSlice[sliceCount].transform.parent = null;
            BreadSlice[sliceCount].GetComponent<MeshCollider>().enabled = true;*/
            //this.transform.parent = collision.gameObject.transform;
            //collision.gameObject.SendMessage("ShowBread");
            Destroy(gameObject);
            
          
            //this.GetComponent<Rigidbody>().isKinematic = true;

            //�浹Ƚ���� 1ȸ�� ����
            //crashCount++;
        }
    }
}
