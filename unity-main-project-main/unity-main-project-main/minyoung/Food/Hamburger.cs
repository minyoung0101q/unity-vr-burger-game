using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hamburger : MonoBehaviour
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
        if (collision.gameObject.CompareTag("Hamburger"))
        {
            collision.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            collision.transform.parent = gameObject.transform;
        }
    }
}
