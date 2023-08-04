using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxItem : MonoBehaviour
{
    //�ڽ� ������ ��ȣ
    public int boxNum;

    public GameObject boxItemPrefabs;

    public List<GameObject> boxItemList = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateItem(Transform tr)
    {
        GameObject boxItem = Instantiate(boxItemPrefabs, tr.position, tr.rotation);

        //������ �ڽ� ������ �̸��� i��° �ڽ� �������� ����
        boxItem.transform.name = boxItemPrefabs.transform.name;

        boxItem.AddComponent<Rigidbody>();
        boxItem.GetComponent<MeshCollider>().isTrigger = false;
        boxItem.GetComponent<Rigidbody>().isKinematic = false;
        boxItem.GetComponent<Rigidbody>().useGravity = true;

        boxItemList.Add(boxItem);
    }
}
