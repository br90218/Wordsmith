using System.Collections;
using System.Collections.Generic;
using Microsoft.Win32;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private string _testString;
    public static readonly int Attack = 0;
    public static readonly int Defend = 1;
    private int _mode;

    // Use this for initialization
    private void Start()
    {
        _mode = Attack;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            print("player switched mode, now is " + _mode);
            _mode = (_mode == Attack ? Defend : Attack);

        }
        else
        {
            foreach (var c in Input.inputString)
            {
                if (c == "\b"[0])
                {
                    if (_testString.Length > 0)
                    {
                        _testString.Remove(_testString.Length - 1);
                    }
                }
                else if (c == "\n"[0] || c == "\r"[0])
                {
                    print("Player entered String: " + _testString + "; word valid: " +
                          WordDictionary.Singleton.CheckWord(_testString));
                    if(WordDictionary.Singleton.CheckWord((_testString))) ShootString(_testString);
                    _testString = "";
                }
                else
                    _testString += c;
            }
        }
    }

    private void ShootString(string word)
    {
        //play clip
        //play sound
        //shoot word
        
    }
}