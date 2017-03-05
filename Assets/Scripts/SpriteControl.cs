using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteControl : MonoBehaviour
{

    private Sprite[] _materials;
    private int _material;

	// Use this for initialization
    private void Start ()
    {
        _material = StageManager.Stone;
    }
	
	// Update is called once per frame
    private void Update ()
    {
		
	}

    public void SetCharMaterial(char c, int type)
    {

        LoadMaterials(c);

        if (type == StageManager.Stone)
        {
            GetComponent<SpriteRenderer>().sprite = _materials[0];
        }
        else if (type == StageManager.Iron)
        {
            GetComponent<SpriteRenderer>().sprite = _materials[1];
        }
        else if (type == StageManager.Gold)
        {
            GetComponent<SpriteRenderer>().sprite = _materials[2];
        }
        else
        {
            throw new ArgumentException("Wrong material type received: " + type);

        }
        _material = type;
    }


    private void LoadMaterials(char c)
    {
        try
        {
            _materials = Resources.LoadAll<Sprite>("Sprites/" + c.ToString().ToUpper());
        }
        catch (Exception e)
        {
            Debug.Log("Loading Sprites for " + this.name + " failed." + e);

        }
    }
}
