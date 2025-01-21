using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    private int _idx = 0;

    public SpriteRenderer front;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void SetCard(int id)
    {
        _idx = id;
        front.sprite = Resources.Load<Sprite>($"Sprites/rtan{_idx}");
    }
}
