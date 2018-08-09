using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour
{
	public string MainLevel;
	public string StartLevels;
	public int playerLives;
	public int playerHealth;
    public GameObject exitYa;
    public GameObject exitTidak;
    public GameObject exitPanel;
    public GameObject exitBG;
    public GameObject btnBack;
    public GameObject panelCredit;

    public AudioSource MyFx;
    public AudioClip FxClick;

	public void NewGame ()
	{
		PlayerPrefs.SetInt ("PlayerCurrentLives", this.playerLives);
		PlayerPrefs.SetInt ("CurrentPlayerScore", 0);
		PlayerPrefs.SetInt ("PlayerCurrentHealth", this.playerHealth);
		PlayerPrefs.SetInt ("PlayerMaxHealth", this.playerHealth);
		Application.LoadLevel (this.MainLevel);
        MyFx.PlayOneShot(FxClick);
	}

	public void LevelSelect ()
	{
		PlayerPrefs.SetInt ("PlayerCurrentLives", this.playerLives);
		PlayerPrefs.SetInt ("CurrentPlayerScore", 0);
		PlayerPrefs.SetInt ("PlayerCurrentHealth", this.playerHealth);
		PlayerPrefs.SetInt ("PlayerMaxHealth", this.playerHealth);
		Application.LoadLevel (this.StartLevels);
        MyFx.PlayOneShot(FxClick);
    }

	public void QuitGame ()
	{
        if (this.gameObject.name == "btnYa")
        {
            //Application.Quit;
            print("Keluar");
            MyFx.PlayOneShot(FxClick);
        }
        else if (this.gameObject.name == "btnTidak")
        {
            exitBG.active = false;
            exitPanel.active = false;
            exitYa.active = false;
            exitTidak.active = false;
            MyFx.PlayOneShot(FxClick);
        }
        else if (this.gameObject.name == "btnQuit")
        {
            exitBG.active = true;
            exitPanel.active = true;
            exitYa.active = true;
            exitTidak.active = true;
            MyFx.PlayOneShot(FxClick);
        }
    }

    public void CreditGame()
    {
        if (this.gameObject.name == "btnBack")
        {
            exitBG.active = false;
            panelCredit.active = false;
            btnBack.active = false;
            MyFx.PlayOneShot(FxClick);
        }
        else if (this.gameObject.name == "btnCredit")
        {
            exitBG.active = true;
            panelCredit.active = true;
            btnBack.active = true;
            MyFx.PlayOneShot(FxClick);
        }
    }

}
