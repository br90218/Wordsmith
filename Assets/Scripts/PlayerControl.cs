using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	private string _testString;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update() {
		foreach (char c in Input.inputString) {
			if (c == "\b" [0]) {
				if (_testString.Length > 0) {
					_testString.Remove (_testString.Length - 1);
				}
			} else if (c == "\n" [0] || c == "\r" [0]) {
				
				print ("Player entered String: " + _testString + "; word valid: " + WordDictionary.singleton.checkWord(_testString));
				_testString = "";
			}
				else
					_testString += c;
		}
	}
}
