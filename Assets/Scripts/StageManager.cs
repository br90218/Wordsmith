using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour
{

    [SerializeField] private GameObject _alphabet;

    public static readonly int Stone = 0;
    public static readonly int Iron = 1;
    public static readonly int Gold = 2;

	// Use this for initialization
	void Start () {
		print (WordDictionary.Singleton.GetFilePath ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public GameObject CharacterInstantiate(char c, int material)
    {
        var character = Instantiate(_alphabet);
        //adjust character and hardness
        character.GetComponent<SpriteControl>().SetCharMaterial(c, material);

        return character;
    }
}
