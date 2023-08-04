using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrayScore : MonoBehaviour
{
    //제출한 음식
    public GameObject foodServed;

    public ScoreManager scoremanager;
    public OrderManager ordermanager;

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
        if (collision.gameObject.CompareTag("Plate"))
        {
            this.GetComponent<AudioSource>().Play();
            Debug.Log("부딪침");

            foodServed = collision.gameObject;
            Debug.Log("score ");

            ordermanager.served();

            Destroy(collision.gameObject);
            Debug.Log("Delete");
            //collision.gameObject.GetComponent<Dish>().upIngredients = null;
        }
        
    }
}