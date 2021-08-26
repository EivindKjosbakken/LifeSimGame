using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SavePrefs : MonoBehaviour
{

	int intToSave = 1;
	float floatToSave;
	string stringToSave = "";

	public Text integerText;


	/*
	void OnGUI()
	{

		
		if (GUI.Button(new Rect(0, 0, 125, 50), "Raise Integer"))
			intToSave++;
		
		
		GUI.Label(new Rect(375, 0, 125, 50), "Integer value is "
				   + intToSave);
		
		
		if (GUI.Button(new Rect(750, 0, 125, 50), "Save Your Game"))
			SaveGame();
		if (GUI.Button(new Rect(750, 100, 125, 50),
					"Load Your Game"))
			LoadGame();
		if (GUI.Button(new Rect(750, 200, 125, 50),
					"Reset Save Data"))
			ResetData();
	}
		*/

	public void IncreaseInteger()
    {
		intToSave++;
		integerText.text = intToSave.ToString("0");
    }



	

	public void ResetData()
	{
		PlayerPrefs.DeleteAll();
		intToSave = 0;
		integerText.text = intToSave.ToString("0");

		Debug.Log("Data reset complete");
	}


	/*
	
	public int score;


     void OnGUI()
    {
		
		
		GUI.Label(new Rect(375, 0, 125, 50), "Integer value is "
				   + score);
	
		if (GUI.Button(new Rect(750, 0, 125, 50), "Save Your Game"))
			SaveGame();
		if (GUI.Button(new Rect(750, 100, 125, 50),
					"Load Your Game"))
			LoadGame();
		if (GUI.Button(new Rect(750, 200, 125, 50),
					"Reset Save Data"))
			ResetData();
	}


	void SaveGame()
	{
		PlayerPrefs.SetInt("SavedInteger", score);
		
		PlayerPrefs.Save();
		Debug.Log("Game data saved!");
	}


	void LoadGame()
	{
		if (PlayerPrefs.HasKey("SavedInteger"))
		{
			score = PlayerPrefs.GetInt("SavedInteger");
			
			Debug.Log("Game data loaded!");
		}
		else
			Debug.LogError("There is no save data!");
	}

	void ResetData()
	{
		PlayerPrefs.DeleteAll();
		score = 0;
		
		Debug.Log("Data reset complete");
	}

	
	*/
}
