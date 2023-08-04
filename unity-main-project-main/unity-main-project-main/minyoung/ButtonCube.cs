using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCube : MonoBehaviour
{
    public Transform downPos;
    public Transform upPos;

    private Vector3 originPos;

    // Start is called before the first frame update
    void Start()
    {
        originPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(originPos.x, Mathf.Clamp(transform.position.y,downPos.position.y, upPos.position.y) , originPos.z);
    }

    public void OnTriggerEnter(Collider other)
    {
        this.GetComponent<Rigidbody>().isKinematic = false;
    }

    public void resetPos()
    {
        transform.position = new Vector3(originPos.x, Mathf.Clamp(transform.position.y, downPos.position.y, upPos.position.y), originPos.z);
        this.GetComponent<Rigidbody>().isKinematic = true;
    }
}
