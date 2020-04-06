﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SmallStarScoreController : MonoBehaviour {

    public GameObject scoreText;
    public int score = 0;

	// Use this for initialization
	void Start () {

        this.scoreText = GameObject.Find("ScoreText");


        


	}
	
	// Update is called once per frame
	void Update () {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision . gameObject.tag == "SmallStarTag")
        {
            score += 10;
            scoreText.GetComponent<Text>().text = "" + score;
        }
    }
}
