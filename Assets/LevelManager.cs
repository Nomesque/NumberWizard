using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string LevelName) {
		Debug.Log("Level requested: " + LevelName);
	}
}
