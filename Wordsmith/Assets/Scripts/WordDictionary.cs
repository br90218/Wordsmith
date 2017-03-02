using System;
using System.Collections.Generic;
using UnityEngine;

public class WordDictionary
{
	public static WordDictionary singleton = new WordDictionary();
	private String _filePath = Application.dataPath + "/Resources/words.txt";
	private HashSet<String> dictionary;
	private WordDictionary ()
	{
		dictionary = new HashSet<String> ();
		System.IO.StreamReader file = new System.IO.StreamReader (_filePath);
		String line;
		while ((line = file.ReadLine()) != null){
			dictionary.Add (line);
		}
		file.Close ();
	}
	public String getFilePath()
	{
		return _filePath;
	}
		
	public bool checkWord(String word){
		return dictionary.Contains (word);
	}
}


