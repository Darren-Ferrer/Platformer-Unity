using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip jumpSound;
    public static AudioClip winSound;
    static AudioSource audioSrc;

    public static void PlaySound(string clip)
    {
        switch(clip)
        {
            case "jump":
            audioSrc.PlayOneShot(jumpSound);
            break;
            case "win":
            audioSrc.PlayOneShot(winSound);
            break;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        jumpSound = Resources.Load<AudioClip>("jump");
        winSound = Resources.Load<AudioClip>("win");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
