﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print (WordDictionary.Singleton.GetFilePath ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
