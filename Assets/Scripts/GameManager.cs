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
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        _time += Time.deltaTime;
        timeText.text = _time.ToString("N1");
    }

    public void MatchCard()
    {
        if(first.idx == second.idx)
        {
            first.InvokeDestroy();
            second.InvokeDestroy();
        }
        else
        {
            first.InvokeClose();
            second.InvokeClose();
        }

        first = null;
        second = null;
    }
}
