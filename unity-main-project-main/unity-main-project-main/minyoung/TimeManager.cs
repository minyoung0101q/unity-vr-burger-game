using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public float GameTime;

    public Text timer;

    public MainMenu mM;
    public bool mainButton = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (mainButton)
        {
            //���� Ÿ�̸� ����
            if ((int)GameTime == 0)
            {
                //Debug.Log("���� ����");
                timer.text = "���� ����";
                mM.GameEnd();
            }
            else
            {
                GameTime -= Time.deltaTime;
                //Debug.Log((int)GameTime);
                timer.text = "Time: " + (int)GameTime;
            }
        }
        
    }
}
