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
            //게임 타이머 설정
            if ((int)GameTime == 0)
            {
                //Debug.Log("게임 종료");
                timer.text = "게임 종료";
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
