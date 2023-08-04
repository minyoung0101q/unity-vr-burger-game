using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxItem : MonoBehaviour
{
    //박스 아이템 번호
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

        //생성된 박스 아이템 이름을 i번째 박스 내용으로 변경
        boxItem.transform.name = boxItemPrefabs.transform.name;

        boxItem.AddComponent<Rigidbody>();
        boxItem.GetComponent<MeshCollider>().isTrigger = false;
        boxItem.GetComponent<Rigidbody>().isKinematic = false;
        boxItem.GetComponent<Rigidbody>().useGravity = true;

        boxItemList.Add(boxItem);
    }
}
