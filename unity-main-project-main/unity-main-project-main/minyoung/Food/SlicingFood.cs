using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlicingFood : MonoBehaviour
{
    //충돌 횟수
    public int sliceCount;

    public List<GameObject> Slice = new List<GameObject>();

    public List<Text> _debugText = new List<Text>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_debugText.Count > 0)
        {
            _debugText[0].text = this.GetComponent<Rigidbody>().isKinematic.ToString();
            _debugText[1].text = this.GetComponent<Rigidbody>().useGravity.ToString();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        //충돌한 물체의 Tag가 Knife라면
        if (collision.gameObject.CompareTag("Knife"))
        {
            Slice[sliceCount].AddComponent<Rigidbody>();
            Slice[sliceCount].transform.parent = null;
            //Slice[sliceCount].GetComponent<MeshCollider>().enabled = true;
            Slice[sliceCount].GetComponent<MeshCollider>().isTrigger = false;
            Slice[sliceCount].GetComponent<Rigidbody>().isKinematic = false;
            Slice[sliceCount].GetComponent<Rigidbody>().useGravity = true;
            //충돌횟수를 1회씩 증가
            sliceCount++;
          
        }


    }

}
