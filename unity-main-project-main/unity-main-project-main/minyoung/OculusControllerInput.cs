using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OculusControllerInput : MonoBehaviour
{
    /*//디버깅 텍스트
    public Text _debugText;
    public Text _debugText2;*/


    //콘트롤러 레이저
    //public List<Laser> laser = new List<Laser>();

    public OVRGrabber grabLeft;
    public OVRGrabber grabRight;

    //베지어 레이저
    //public BezierLaser bezierLaserL;
    //public BezierLaser bezierLaserR;

    //핸드 센서
    public HandSensor handSensorL;
    public HandSensor handSensorR;


    //타워 디펜스 매니저
    //public TowerDefenseManager towerManager;

    //사운드 매니저
    //public TowerDefenseSound soundManager;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //왼손 트리거 입력
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            /*_debugText.text = "왼손 트리거 입력";*/

            //레이저 충돌체 잡기
            //laser[0].LaserGripUpdate(true);

        }
        //왼손 트리거 떼기
        if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger))
        {
            /*_debugText.text = "왼손 트리거 입력";*/

            //레이저 충돌체 잡기
            //laser[0].LaserGripUpdate(false);

        }

        //오른손 트리거 입력
        if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
        {
            /*//오른손에 아이템이 있을 때
            if (handSensorR.handItem)
            {

                handSensorR.BoxItemOn(handSensorR.handItemNum, handSensorR.transform.position);
                //handSensorR.Item.GetComponent<OVRGrabbable>().GrabBegin(grabRight, handSensorR.GetComponent<Collider>());
                handSensorR.GetComponent<OVRGrabber>().GrabBegin();

                *//* //타워매니저의 코스트 가격이 선택한 아이템의 코스트(절대값)보다 크거나 같을 경우
                 if (towerManager.cost >= Mathf.Abs(handSensorR.handItem.GetComponent<TowerItem>().itemCost))
                 {
                     //베지어 레이저 켜기(아이템 번호, 아이템 코스트)
                     bezierLaserR.BezierLaserOn(handSensorR.handItem.GetComponent<TowerItem>().towerNum,
                         handSensorR.handItem.GetComponent<TowerItem>().itemCost);
                 }
                 //코스트가 모자란 경우
                 else
                 {
                     //돈이 없다고 하는 음성 재생
                     soundManager.EffectSoundPlay(0);
                 }*//*
            }*/
            //오른손 베지어 레이저에 충돌된 게임 오브젝트가 있다면
            /*if (bezierLaserR.towerBuildLane)
            {
                //타워 건설 (오른손 베지어 레이저에 충돌된 게임 오브젝트의 위치)
                
            }*/

            /* _debugText.text = "오른손 트리거 입력";*/
            //레이저 충돌체 잡기
            //laser[1].LaserGripUpdate(true);
        }
        //오른손 트리거 떼기
        if (OVRInput.GetUp(OVRInput.Button.SecondaryIndexTrigger))
        {
            /* _debugText.text = "오른손 트리거 입력";*/
            //레이저 충돌체 잡기
            //laser[1].LaserGripUpdate(false);
        }

        //왼손 그립 버튼 입력
        if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger))
        {
            /* _debugText.text = "왼손 그립 버튼 입력";*/
        }

        //오른손 그립 버튼 입력
        if (OVRInput.GetDown(OVRInput.Button.SecondaryHandTrigger))
        {   //오른손에 아이템이 있을 때
            if (handSensorR.handItem)
            {
                handSensorR.handItem.GetComponent<BoxItem>().CreateItem(grabRight.transform);
                handSensorR.GetComponent<HandSensor>().HandReset();

                //handSensorR.Item.GetComponent<OVRGrabbable>().GrabBegin(grabRight, handSensorR.GetComponent<Collider>());
                //handSensorR.GetComponent<OVRGrabber>().GrabBegin();
                /* _debugText.text = "오른손 입력";*/
            }
        }

        //왼손 A버튼 입력
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            /* _debugText.text = "왼손 A버튼 입력";*/
        }

        //왼손 B버튼 입력
        if (OVRInput.GetDown(OVRInput.Button.Two))
        {
            /* _debugText.text = "왼손 B버튼 입력";*/
        }
        //오른손 X버튼 입력
        if (OVRInput.GetDown(OVRInput.Button.Three))
        {
            /*  _debugText.text = "오른손 X버튼 입력";*/
        }
        //오른손 Y버튼 입력
        if (OVRInput.GetDown(OVRInput.Button.Four))
        {
            /*_debugText.text = "오른손 Y버튼 입력";*/
        }

        //왼손 조이스틱 클릭
        if (OVRInput.GetDown(OVRInput.Button.PrimaryThumbstick))
        {
            /*_debugText.text = "왼손 조이스틱 클릭";*/
        }

        //오른손 조이스틱 클릭
        if (OVRInput.GetDown(OVRInput.Button.SecondaryThumbstick))
        {
            /*_debugText.text = "오른손 조이스틱 클릭";*/
        }


        //왼손 조이스틱 이동
        if (OVRInput.Get(OVRInput.Touch.PrimaryThumbstick))
        {
            Vector2 pos = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);
            /*_debugText2.text = pos.ToString();*/
        }
        //오른손 조이스틱 이동
        if (OVRInput.Get(OVRInput.Touch.SecondaryThumbstick))
        {
            Vector2 pos = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick);
            /*_debugText2.text = pos.ToString();*/
        }

        //왼손 트리거 누르기
        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
        {
            float trigger = OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger);
            /*_debugText2.text = trigger.ToString();*/
        }
        //오른손 트리거 누르기
        if (OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger))
        {
            float trigger = OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger);
            /* _debugText2.text = trigger.ToString();*/
        }
        //왼손 그립버튼 누르기
        if (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger))
        {
            float trigger = OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger);
            /*_debugText2.text = trigger.ToString();*/
        }
        //오른손 그립버튼 누르기
        if (OVRInput.Get(OVRInput.Button.SecondaryHandTrigger))
        {
            float trigger = OVRInput.Get(OVRInput.Axis1D.SecondaryHandTrigger);
            /*_debugText2.text = trigger.ToString();*/
        }
    }
}
