using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject intro;
    public AudioSource audioPlr;

    public AudioClip introOst;
    // Start is called before the first frame update
    void Start()
    {
        audioPlr.clip = introOst;
        audioPlr.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            intro.SetActive(false);
            audioPlr.Stop();
        }
    }
}
