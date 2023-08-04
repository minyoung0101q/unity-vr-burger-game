using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrderManager : MonoBehaviour
{
    //주문 텍스트
    public Text OrderText;
    //주문 갯수
    public int OrderCount;

    //레시피 텍스트
    public Text recipeText;

    //점수 접근용 
    public ScoreManager scoremanager;

    //난이도
    public int difficulty;

    //재료 판별 매니저
    public PlateUpPosManager plateupPos;

    //밑빵 이름 리스트
    public List<string> BreadDown = new List<string>();
    //재료 이름 리스트
    public List<string> BurgerIn = new List<string>();
    //윗빵 이름 리스트
    public List<string> BreadUp = new List<string>();

    //랜덤 나온 재료 이름
    private string breadDownStr;
    private string burgerInOneStr;
    private string burgerInTwoStr;
    private string burgerInThreeStr;
    private string breadUpStr;


    // Start is called before the first frame update
    void Start()
    {
        /*for(int i = 0; i < BreadDown.Count; i++)
        {
            if (BreadDown[i].transform.name.Contains("Bread"))
            {

            }
        }*/

        BreadDown.Add("Burger Bread  Down A");
        BreadDown.Add("Burger Bread  Down B");

        BurgerIn.Add("Cutlet");
        BurgerIn.Add("Cheese Slice");
        BurgerIn.Add("Tomato Slice");
        BurgerIn.Add("Salad Slice");
        BurgerIn.Add("Pepper Yellow Slice");
        BurgerIn.Add("Orange");


        BreadUp.Add("Burger Bread A");
        BreadUp.Add("Burger Bread B");


        recipe();
    }

    // Update is called once per frame
    void Update()
    {
        OrderText.text = "Order" + "\n Level" + difficulty;
    }

    public void recipe()
    {
        if (OrderCount > 4 && scoremanager.totalScore > 200)
        {
            difficulty = 3;
            OrderCount++;

            int randDown = Random.Range(0, BreadDown.Count);
            int randInOne = Random.Range(0, BurgerIn.Count);
            int randInTwo = Random.Range(0, BurgerIn.Count);
            int randInThree = Random.Range(0, BurgerIn.Count);
            int randUp = Random.Range(0, BreadUp.Count);

            breadDownStr = BreadDown[randDown];
            burgerInOneStr = BurgerIn[randInOne];
            burgerInTwoStr = BurgerIn[randInTwo];
            burgerInThreeStr = BurgerIn[randInThree];
            breadUpStr = BreadUp[randUp];

            recipeText.text = BreadUp[randUp] + "\n" + BurgerIn[randInOne] + "\n" + BurgerIn[randInTwo] + "\n" + BurgerIn[randInThree] + "\n" + BreadDown[randDown] ;

        }
        else if (OrderCount > 2 && scoremanager.totalScore > 100)
        {
            difficulty = 2;
            OrderCount++;

            int randDown = Random.Range(0, BreadDown.Count);
            int randInOne = Random.Range(0, BurgerIn.Count);
            int randInTwo = Random.Range(0, BurgerIn.Count);
            int randUp = Random.Range(0, BreadUp.Count);

            breadDownStr = BreadDown[randDown];
            burgerInOneStr = BurgerIn[randInOne];
            burgerInTwoStr = BurgerIn[randInTwo];
            breadUpStr = BreadUp[randUp];

            recipeText.text = BreadUp[randUp] + "\n" + BurgerIn[randInOne] + "\n" + BurgerIn[randInTwo] + "\n" +BreadDown[randDown] ;


        }
        else
        {
            difficulty = 1;
            OrderCount++;

            int randDown = Random.Range(0, BreadDown.Count);
            int randIn = Random.Range(0, BurgerIn.Count);
            int randUp = Random.Range(0, BreadUp.Count);

            breadDownStr = BreadDown[randDown];
            burgerInOneStr = BurgerIn[randIn];
            breadUpStr = BreadUp[randUp];

            recipeText.text = BreadUp[randUp] + "\n" + BurgerIn[randIn] + "\n" + BreadDown[randDown];
        }


    }
    public void served()
    {
        int count = 0;
        List<GameObject> temp = new List<GameObject>();
        for (int i = 0; i < plateupPos.upFoodList.Count; i++)
        {
            if (!temp.Contains(plateupPos.upFoodList[i])) //temp에 list[i]의 원소가 있으면 true 아니면 false이므로 (!가 있어서 원소가 없을때 true로 바뀌어서 추가된다.)
                temp.Add(plateupPos.upFoodList[i]); //temp list에 추가한다.
        }
        plateupPos.upFoodList.Clear();
        

        switch (difficulty)
        {
            case 1:
                {
                    for (int i = 0; i < temp.Count; i++)
                    {
                        if (temp[i].name.Contains(breadDownStr))
                        {
                            count++;
                        }
                        else if (temp[i].name.Contains(breadUpStr))
                        {
                            count++;
                        }
                        else if (temp[i].name.Contains(burgerInOneStr))
                        {
                            count++;
                        }

                    }
                    if (count == 3)
                    {
                        scoremanager.servedFoodScore(true);
                    }
                    else
                    {
                        scoremanager.servedFoodScore(false);
                    }
                    break;
                }
            case 2:
                {
                    for (int i = 0; i < temp.Count; i++)
                    {
                        if (temp[i].name.Contains(breadDownStr))
                        {
                            count++;
                        }
                        else if (temp[i].name.Contains(breadUpStr))
                        {
                            count++;
                        }
                        else if (temp[i].name.Contains(burgerInOneStr))
                        {
                            count++;
                        }
                        else if (temp[i].name.Contains(burgerInTwoStr))
                        {
                            count++;
                        }

                    }
                    if (count == 4)
                    {
                        scoremanager.servedFoodScore(true);
                    }
                    else
                    {
                        scoremanager.servedFoodScore(false);
                    }
                    break;
                }
            case 3:
                {
                    for (int i = 0; i < temp.Count; i++)
                    {
                        if (temp[i].name.Contains(breadDownStr))
                        {
                            count++;
                        }
                        else if (temp[i].name.Contains(breadUpStr))
                        {
                            count++;
                        }
                        else if (temp[i].name.Contains(burgerInOneStr))
                        {
                            count++;
                        }
                        else if (temp[i].name.Contains(burgerInTwoStr))
                        {
                            count++;
                        }
                        else if (temp[i].name.Contains(burgerInThreeStr))
                        {
                            count++;
                        }

                    }
                    if (count == 5)
                    {
                        scoremanager.servedFoodScore(true);
                    }
                    else
                    {
                        scoremanager.servedFoodScore(false);
                    }
                    break;
                }
        }

        temp.Clear();
    }
}
