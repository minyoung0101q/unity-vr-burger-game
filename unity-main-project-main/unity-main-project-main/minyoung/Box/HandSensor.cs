using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandSensor : MonoBehaviour
{
    //�տ� ������ ������
    public GameObject handItem;
    //�տ� ������ �������� ����(��ȣ)
    //public int handItemNum = -1;

    //�տ� ������ ������ ������
    public GameObject PrefabIn;

    /*//���� ������ ����
    public List<GameObject> PrefabIn = new List<GameObject>();*/

    //�ڽ� ������
    public GameObject Item;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //Ʈ���� �浹 ����
    public void OnTriggerEnter(Collider other)
    {
        //�浹�� ��ü�� Tag�� Box���
        if (other.transform.CompareTag("Box"))
        {
            //������ ��ü�� �����Ѵ�.
            handItem = other.transform.gameObject;

            //�տ� ������ �������� ������ �����Ѵ�.(��ȣ�� �޾ƿ�)
            //handItemNum = other.transform.GetComponent<BoxItem>().boxNum;
        }
    }

    //Ʈ���� �浹 ����
    public void OnTriggerExit(Collider other)
    {
        //�浹�� ��ü�� Tag�� Box���
        if (other.transform.CompareTag("Box"))
        {
            //������ ������ �ʱ�ȭ
            handItem = null;
            //������ ��ȣ �ʱ�ȭ
            //handItemNum = -1;
        }
    }

    //�ڽ� ������ ����
    public void HandReset()
    {
        handItem = null;
        PrefabIn = null;
    }
}
