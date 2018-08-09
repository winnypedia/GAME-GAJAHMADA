using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverMenu : MonoBehaviour {

    public string ulangi;
    public string menuUtama;
    public string pilihLevel;
    public int playerLives;
    public int playerHealth;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Ulangi()
    {
        PlayerPrefs.SetInt("PlayerCurrentLives", this.playerLives);
        PlayerPrefs.SetInt("CurrentPlayerScore", 0);
        PlayerPrefs.SetInt("PlayerCurrentHealth", this.playerHealth);
        PlayerPrefs.SetInt("PlayerMaxHealth", this.playerHealth);
        Application.LoadLevel(this.ulangi);
    }

    public void MenuUtama()
    {
        Application.LoadLevel(this.menuUtama);
    }

    public void PilihLevel()
    {
        Application.LoadLevel(this.pilihLevel);
    }
}
