using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenTempManager : MonoBehaviour
{
    public Transform spawnPoint;

    public List<GameObject> foodList = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            RandomCreateFood();
        }
    }

    public void RandomCreateFood()
    {
        int r = Random.Range(0, foodList.Count);

        GameObject food = Instantiate(foodList[r], spawnPoint.position, spawnPoint.rotation);
    }
}
