using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnpuController : MonoBehaviour
{
    // 音源をドラックして、設定できるようにしている
    public AudioSource audio0;
    public AudioSource audio1;
    public AudioSource audio2;
    public AudioSource audio3;
    public AudioSource audio4;
    public AudioSource audio5;
    public AudioSource audio6;
    public AudioSource audio7;
    public AudioSource audio8;
    public AudioSource audio9;
    public AudioSource audio10;
    public AudioSource audio11;
    public AudioSource audio12;
    public AudioSource audio13;
    public AudioSource audio14;
    public AudioSource audio15;
    public AudioSource audio16;
    public AudioSource audio17;
    public AudioSource audio18;
    public AudioSource audio19;
    public AudioSource audio20;
    public AudioSource audio21;
    public AudioSource audio22;
    public AudioSource audio23;

    //音源のlist
    List<AudioSource> onpu = new List<AudioSource>();


    // Start is called before the first frame update
    void Start()
    {
        //音源listに追加している
        onpu.Add(audio0);
        onpu.Add(audio1);
        onpu.Add(audio2);
        onpu.Add(audio3);
        onpu.Add(audio4);
        onpu.Add(audio5);
        onpu.Add(audio6);
        onpu.Add(audio7);
        onpu.Add(audio8);
        onpu.Add(audio9);
        onpu.Add(audio10);
        onpu.Add(audio11);
        onpu.Add(audio12);
        onpu.Add(audio13);
        onpu.Add(audio14);
        onpu.Add(audio15);
        onpu.Add(audio16);
        onpu.Add(audio17);
        onpu.Add(audio18);
        onpu.Add(audio19);
        onpu.Add(audio20);
        onpu.Add(audio21);
        onpu.Add(audio22);
        onpu.Add(audio23);
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void Play(int note)
    {
        if (note < 25)
        {
            Debug.Log("OnpuController : Play" + note);// note 番に対応する音を出す
            onpu[note].volume = 1;
            onpu[note].Play();
        }
        else
        {
            Debug.Log("OnpuController : Unknow" + note);
        }
    }

    public void Stop(int note)
    {
        if (note < 25)
        {
            Debug.Log("OnpuController : Stop" + note);// note 番に対応する音を止める
            StartCoroutine(waitTime(note));
        }
        else
        {
            Debug.Log("OnpuController : Unknow" + note);
        }
    }

    IEnumerator waitTime(int note)
    {
        onpu[note].volume = 0;
        Debug.Log("StartCountDown");
        yield return new WaitForSeconds(0.7f);
        onpu[note].Stop();
        Debug.Log("FinshCountDown");
    }
}
