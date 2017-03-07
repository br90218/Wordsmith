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
    private void Start()
    {
        print(WordDictionary.Singleton.GetFilePath());
        ResizeSpriteToScreen();
    }

    // Update is called once per frame
    private void Update()
    {
    }

    public GameObject CharacterInstantiate(char c, int material)
    {
        var character = Instantiate(_alphabet);
        //adjust character and hardness
        character.GetComponent<SpriteControl>().SetCharMaterial(c, material);

        return character;
    }
    void ResizeSpriteToScreen()
    {
        var sr = GetComponent<SpriteRenderer>();
        if (sr == null) return;

        transform.localScale = new Vector3(1,1,1);

        var width = sr.sprite.bounds.size.x;
        var height = sr.sprite.bounds.size.y;

        var worldScreenHeight = Camera.main.orthographicSize * 2.0;
        var worldScreenWidth = worldScreenHeight / Screen.height * Screen.width;

        transform.localScale = new Vector3((float) worldScreenWidth / width, (float) worldScreenHeight / height,
            transform.localScale.z);

//        transform.localScale.x = worldScreenWidth / width;
//        transform.localScale.y = worldScreenHeight / height;
    }

}