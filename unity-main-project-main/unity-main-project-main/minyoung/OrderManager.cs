using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrderManager : MonoBehaviour
{
    //�ֹ� �ؽ�Ʈ
    public Text OrderText;
    //�ֹ� ����
    public int OrderCount;

    //������ �ؽ�Ʈ
    public Text recipeText;

    //���� ���ٿ� 
    public ScoreManager scoremanager;

    //���̵�
    public int difficulty;

    //��� �Ǻ� �Ŵ���
    public PlateUpPosManager plateupPos;

    //�ػ� �̸� ����Ʈ
    public List<string> BreadDown = new List<string>();
    //��� �̸� ����Ʈ
    public List<string> BurgerIn = new List<string>();
    //���� �̸� ����Ʈ
    public List<string> BreadUp = new List<string>();

    //���� ���� ��� �̸�
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
            if (!temp.Contains(plateupPos.upFoodList[i])) //temp�� list[i]�� ���Ұ� ������ true �ƴϸ� false�̹Ƿ� (!�� �־ ���Ұ� ������ true�� �ٲ� �߰��ȴ�.)
                temp.Add(plateupPos.upFoodList[i]); //temp list�� �߰��Ѵ�.
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
