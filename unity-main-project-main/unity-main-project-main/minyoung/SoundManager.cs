using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public List<AudioSource> BGM = new List<AudioSource>();

    public int trackNum;
    // Start is called before the first frame update
    void Start()
    {
        //BGMplay();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BGMplay()
    {
        BGM[0].Stop();
        BGM[1].Play();
        //StartCoroutine("NextTrack");
    }
    public void BGMGameStop()
    {
        BGM[1].Stop();
        //BGM[2].Play();
        //StartCoroutine("NextTrack");
    }
    IEnumerator NextTrack()
    {
        yield return new WaitForSeconds(BGM[trackNum].clip.length);
        
        if(trackNum < BGM.Count-1)
        {
            trackNum++;
        }
        else
        {
            trackNum = 0;
        }
        BGMplay();
    }

    public void NextTrackPlay()
    {
        StopCoroutine("NextTrack");
        if (trackNum < BGM.Count - 1)
        {
            trackNum++;
        }
        else
        {
            trackNum = 0;
        }
        BGMplay();
    }
}
