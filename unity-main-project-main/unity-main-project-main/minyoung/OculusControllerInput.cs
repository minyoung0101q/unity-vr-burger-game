using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OculusControllerInput : MonoBehaviour
{
    /*//����� �ؽ�Ʈ
    public Text _debugText;
    public Text _debugText2;*/


    //��Ʈ�ѷ� ������
    //public List<Laser> laser = new List<Laser>();

    public OVRGrabber grabLeft;
    public OVRGrabber grabRight;

    //������ ������
    //public BezierLaser bezierLaserL;
    //public BezierLaser bezierLaserR;

    //�ڵ� ����
    public HandSensor handSensorL;
    public HandSensor handSensorR;


    //Ÿ�� ���潺 �Ŵ���
    //public TowerDefenseManager towerManager;

    //���� �Ŵ���
    //public TowerDefenseSound soundManager;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //�޼� Ʈ���� �Է�
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            /*_debugText.text = "�޼� Ʈ���� �Է�";*/

            //������ �浹ü ���
            //laser[0].LaserGripUpdate(true);

        }
        //�޼� Ʈ���� ����
        if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger))
        {
            /*_debugText.text = "�޼� Ʈ���� �Է�";*/

            //������ �浹ü ���
            //laser[0].LaserGripUpdate(false);

        }

        //������ Ʈ���� �Է�
        if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
        {
            /*//�����տ� �������� ���� ��
            if (handSensorR.handItem)
            {

                handSensorR.BoxItemOn(handSensorR.handItemNum, handSensorR.transform.position);
                //handSensorR.Item.GetComponent<OVRGrabbable>().GrabBegin(grabRight, handSensorR.GetComponent<Collider>());
                handSensorR.GetComponent<OVRGrabber>().GrabBegin();

                *//* //Ÿ���Ŵ����� �ڽ�Ʈ ������ ������ �������� �ڽ�Ʈ(���밪)���� ũ�ų� ���� ���
                 if (towerManager.cost >= Mathf.Abs(handSensorR.handItem.GetComponent<TowerItem>().itemCost))
                 {
                     //������ ������ �ѱ�(������ ��ȣ, ������ �ڽ�Ʈ)
                     bezierLaserR.BezierLaserOn(handSensorR.handItem.GetComponent<TowerItem>().towerNum,
                         handSensorR.handItem.GetComponent<TowerItem>().itemCost);
                 }
                 //�ڽ�Ʈ�� ���ڶ� ���
                 else
                 {
                     //���� ���ٰ� �ϴ� ���� ���
                     soundManager.EffectSoundPlay(0);
                 }*//*
            }*/
            //������ ������ �������� �浹�� ���� ������Ʈ�� �ִٸ�
            /*if (bezierLaserR.towerBuildLane)
            {
                //Ÿ�� �Ǽ� (������ ������ �������� �浹�� ���� ������Ʈ�� ��ġ)
                
            }*/

            /* _debugText.text = "������ Ʈ���� �Է�";*/
            //������ �浹ü ���
            //laser[1].LaserGripUpdate(true);
        }
        //������ Ʈ���� ����
        if (OVRInput.GetUp(OVRInput.Button.SecondaryIndexTrigger))
        {
            /* _debugText.text = "������ Ʈ���� �Է�";*/
            //������ �浹ü ���
            //laser[1].LaserGripUpdate(false);
        }

        //�޼� �׸� ��ư �Է�
        if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger))
        {
            /* _debugText.text = "�޼� �׸� ��ư �Է�";*/
        }

        //������ �׸� ��ư �Է�
        if (OVRInput.GetDown(OVRInput.Button.SecondaryHandTrigger))
        {   //�����տ� �������� ���� ��
            if (handSensorR.handItem)
            {
                handSensorR.handItem.GetComponent<BoxItem>().CreateItem(grabRight.transform);
                handSensorR.GetComponent<HandSensor>().HandReset();

                //handSensorR.Item.GetComponent<OVRGrabbable>().GrabBegin(grabRight, handSensorR.GetComponent<Collider>());
                //handSensorR.GetComponent<OVRGrabber>().GrabBegin();
                /* _debugText.text = "������ �Է�";*/
            }
        }

        //�޼� A��ư �Է�
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            /* _debugText.text = "�޼� A��ư �Է�";*/
        }

        //�޼� B��ư �Է�
        if (OVRInput.GetDown(OVRInput.Button.Two))
        {
            /* _debugText.text = "�޼� B��ư �Է�";*/
        }
        //������ X��ư �Է�
        if (OVRInput.GetDown(OVRInput.Button.Three))
        {
            /*  _debugText.text = "������ X��ư �Է�";*/
        }
        //������ Y��ư �Է�
        if (OVRInput.GetDown(OVRInput.Button.Four))
        {
            /*_debugText.text = "������ Y��ư �Է�";*/
        }

        //�޼� ���̽�ƽ Ŭ��
        if (OVRInput.GetDown(OVRInput.Button.PrimaryThumbstick))
        {
            /*_debugText.text = "�޼� ���̽�ƽ Ŭ��";*/
        }

        //������ ���̽�ƽ Ŭ��
        if (OVRInput.GetDown(OVRInput.Button.SecondaryThumbstick))
        {
            /*_debugText.text = "������ ���̽�ƽ Ŭ��";*/
        }


        //�޼� ���̽�ƽ �̵�
        if (OVRInput.Get(OVRInput.Touch.PrimaryThumbstick))
        {
            Vector2 pos = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);
            /*_debugText2.text = pos.ToString();*/
        }
        //������ ���̽�ƽ �̵�
        if (OVRInput.Get(OVRInput.Touch.SecondaryThumbstick))
        {
            Vector2 pos = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick);
            /*_debugText2.text = pos.ToString();*/
        }

        //�޼� Ʈ���� ������
        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
        {
            float trigger = OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger);
            /*_debugText2.text = trigger.ToString();*/
        }
        //������ Ʈ���� ������
        if (OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger))
        {
            float trigger = OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger);
            /* _debugText2.text = trigger.ToString();*/
        }
        //�޼� �׸���ư ������
        if (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger))
        {
            float trigger = OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger);
            /*_debugText2.text = trigger.ToString();*/
        }
        //������ �׸���ư ������
        if (OVRInput.Get(OVRInput.Button.SecondaryHandTrigger))
        {
            float trigger = OVRInput.Get(OVRInput.Axis1D.SecondaryHandTrigger);
            /*_debugText2.text = trigger.ToString();*/
        }
    }
}
