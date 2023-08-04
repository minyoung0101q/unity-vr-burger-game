using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject main;
    public GameObject End;
    public GameObject mainButton;

    public ScoreManager ScM;
    public TimeManager tM;

    public SoundManager sM;
    public Text endText;

    public ButtonCube buttonCube;
    bool restart = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (restart)
        {
            SceneManager.LoadScene("KitchenScene");
        }
        main.SetActive(false);
        tM.mainButton = true;
        mainButton.SetActive(false);
        sM.BGMplay();
    }

    public void GameEnd()
    {
        End.SetActive(true);
        endText.text = "게임 종료 \n 총 점수 : " + ScM.totalScore + "\n 다시 시작하려면 버튼을 누르세요";
        
        mainButton.SetActive(true);
        sM.BGMGameStop();
        buttonCube.resetPos();
        restart = true;
        
    }
}
