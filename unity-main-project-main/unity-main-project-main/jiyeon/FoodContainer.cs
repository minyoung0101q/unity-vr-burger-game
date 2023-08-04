using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodContainer : MonoBehaviour
{
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
        if (collision.gameObject.CompareTag("Food"))
        {
            this.GetComponent<Rigidbody>().isKinematic = true;
            this.SendMessage("UpFood",collision.gameObject);

            //if (collision.transform.name == "Bread")
            //{
            //    collision.gameObject.GetComponent<Bread>().BreadDown();
            //}
            StartCoroutine("KinematicFalse");
        }
    }

    IEnumerator KinematicFalse()
    {
        yield return new WaitForSeconds(0.2f);
        this.GetComponent<Rigidbody>().isKinematic = false;
    }
}
