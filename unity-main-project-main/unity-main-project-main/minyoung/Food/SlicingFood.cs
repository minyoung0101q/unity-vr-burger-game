using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlicingFood : MonoBehaviour
{
    //�浹 Ƚ��
    public int sliceCount;

    public List<GameObject> Slice = new List<GameObject>();

    public List<Text> _debugText = new List<Text>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_debugText.Count > 0)
        {
            _debugText[0].text = this.GetComponent<Rigidbody>().isKinematic.ToString();
            _debugText[1].text = this.GetComponent<Rigidbody>().useGravity.ToString();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        //�浹�� ��ü�� Tag�� Knife���
        if (collision.gameObject.CompareTag("Knife"))
        {
            Slice[sliceCount].AddComponent<Rigidbody>();
            Slice[sliceCount].transform.parent = null;
            //Slice[sliceCount].GetComponent<MeshCollider>().enabled = true;
            Slice[sliceCount].GetComponent<MeshCollider>().isTrigger = false;
            Slice[sliceCount].GetComponent<Rigidbody>().isKinematic = false;
            Slice[sliceCount].GetComponent<Rigidbody>().useGravity = true;
            //�浹Ƚ���� 1ȸ�� ����
            sliceCount++;
          
        }


    }

}
