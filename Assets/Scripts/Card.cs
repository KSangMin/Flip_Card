using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    private int _idx = 0;

    public SpriteRenderer frontImage;

    public GameObject front;
    public GameObject back;

    private Animator _anim;

    void Start()
    {
        _anim  = GetComponent<Animator>();
    }

    void Update()
    {
        
    }

    public void SetCard(int id)
    { 
        _idx = id;
        frontImage.sprite = Resources.Load<Sprite>($"Sprites/rtan{_idx}");
    }

    public void FlipCard()
    {
        front.SetActive(true);
        back.SetActive(false);
        _anim.SetBool("isOpen", true);
    }
}
