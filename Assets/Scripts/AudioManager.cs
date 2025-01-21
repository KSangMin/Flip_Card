using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    private AudioSource _audioSource;
    public AudioClip clip;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _audioSource.clip = clip;
        _audioSource.Play();
    }

    void Update()
    {
        
    }
}
