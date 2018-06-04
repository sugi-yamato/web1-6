﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour {

	// Use this for initialization

        GameObject hpGauge;

	void Start () {
        this.hpGauge = GameObject.Find("hpGauge");
		
	}
	
	// Update is called once per frame
	public void DecreaseHp () {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
	}
}
