using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private float _time = 0;
    public Text timeText;

    public Card first;
    public Card second;

    public int CardCount = 0;

    public GameObject endText;

    private AudioSource _audioSource;
    public AudioClip clip;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        Time.timeScale = 1f;
    }

    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        _time += Time.deltaTime;
        timeText.text = _time.ToString("N1");

        if(_time >= 30f)
        {
            GameOver();
        }
    }

    public void MatchCard()
    {
        if(first.idx == second.idx)
        {
            _audioSource.PlayOneShot(clip);
            first.InvokeDestroy();
            second.InvokeDestroy();
            CardCount -= 2;
            if(CardCount <= 0)
            {
                GameOver();
            }
        }
        else
        {
            first.InvokeClose();
            second.InvokeClose();
        }

        first = null;
        second = null;
    }

    public void GameOver()
    {
        endText.SetActive(true);
        Time.timeScale = 0f;
    }
}
