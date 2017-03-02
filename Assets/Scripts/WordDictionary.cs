using System;
using System.Collections.Generic;
using UnityEngine;

public class WordDictionary
{
	public static WordDictionary Singleton = new WordDictionary();
	private readonly string _filePath = Application.dataPath + "/Resources/words.txt";
	private readonly HashSet<string> _dictionary;
	private WordDictionary ()
	{
		_dictionary = new HashSet<string> ();
		var file = new System.IO.StreamReader (_filePath);
		string line;
		while ((line = file.ReadLine()) != null){
			_dictionary.Add (line);
		}
		file.Close ();
	}
	public string GetFilePath()
	{
		return _filePath;
	}
		
	public bool CheckWord(string word){
		return _dictionary.Contains (word.ToLower());
	}
}


