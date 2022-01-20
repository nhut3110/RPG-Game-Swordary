﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chest : collectable
{
    public Sprite emptyChest;
    public int pesosAmount = 5;

    protected override void OnCollect()
    {
        if (!collected)
        {
            collected = true;
            GetComponent<SpriteRenderer>().sprite = emptyChest;
            GameManager.instance.pesos += pesosAmount;
            GameManager.instance.ShowText("+" + pesosAmount + " pesus!", 25, Color.yellow, transform.position, Vector3.up * 25, 1.5f);
        }
        
    }

}
