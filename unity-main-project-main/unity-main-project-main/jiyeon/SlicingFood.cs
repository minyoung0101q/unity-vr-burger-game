using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlicingFood : MonoBehaviour
{
    //�浹 Ƚ��
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
        //�浹�� ��ü�� Tag�� Knife���
        if (collision.gameObject.CompareTag("Knife"))
        {
            BreadSlice[sliceCount].transform.parent = null;
            BreadSlice[sliceCount].GetComponent<MeshCollider>().enabled = true;
            BreadSlice[sliceCount].GetComponent<Rigidbody>().isKinematic = false;
            //�浹Ƚ���� 1ȸ�� ����
            sliceCount++;
          
        }


    }

}
