using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandSensor : MonoBehaviour
{
    //손에 감지된 아이템
    public GameObject handItem;
    //손에 감지된 아이템의 종류(번호)
    //public int handItemNum = -1;

    //손에 감지된 아이템 프리팹
    public GameObject PrefabIn;

    /*//만들 프리팹 생성
    public List<GameObject> PrefabIn = new List<GameObject>();*/

    //박스 아이템
    public GameObject Item;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //트리거 충돌 시작
    public void OnTriggerEnter(Collider other)
    {
        //충돌한 물체의 Tag가 Box라면
        if (other.transform.CompareTag("Box"))
        {
            //감지된 물체를 감별한다.
            handItem = other.transform.gameObject;

            //손에 감지된 아이템의 종류를 감별한다.(번호를 받아옴)
            //handItemNum = other.transform.GetComponent<BoxItem>().boxNum;
        }
    }

    //트리거 충돌 종료
    public void OnTriggerExit(Collider other)
    {
        //충돌한 물체의 Tag가 Box라면
        if (other.transform.CompareTag("Box"))
        {
            //감지된 아이템 초기화
            handItem = null;
            //아이템 번호 초기화
            //handItemNum = -1;
        }
    }

    //박스 아이템 생성
    public void HandReset()
    {
        handItem = null;
        PrefabIn = null;
    }
}
