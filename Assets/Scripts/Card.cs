using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public int idx = 0;

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
        idx = id;
        frontImage.sprite = Resources.Load<Sprite>($"Sprites/rtan{idx}");
    }

    public void FlipCard()
    {
        front.SetActive(true);
        back.SetActive(false);
        _anim.SetBool("isOpen", true);

        if(GameManager.Instance.first == null)
        {
            GameManager.Instance.first = this;
        }
        else
        {
            GameManager.Instance.second = this;
            GameManager.Instance.MatchCard();
        }
    }

    public void InvokeDestroy()
    {
        Invoke("DestroyCard", 1f);
    }

    public void DestroyCard()
    {
        Destroy(gameObject);
    }

    public void InvokeClose()
    {
        Invoke("CloseCard", 1f);
    }

    public void CloseCard()
    {
        front.SetActive(false);
        back.SetActive(true);
        _anim.SetBool("isOpen", false);
    }
}
