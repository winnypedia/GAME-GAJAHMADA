using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour {
    public GameObject cerita1;
    public GameObject cerita2;
    public GameObject cerita3;
    public GameObject cerita4;
    public GameObject cerita5;
    public GameObject cerita6;
    public GameObject soal1;
    public GameObject soal2;
    public GameObject soal3;
    public GameObject soal4;
    public GameObject btnYa;
    public GameObject btnTidak;
    public GameObject btnLanjut;
    public GameObject btnMulai;

    public GameObject char1;
    public GameObject char2;
    public GameObject musuh;

    public AudioSource MyFx;
    public AudioClip FxClick;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ButtonCLick()
    {
        if (this.gameObject.name == "btnLanjut")
        {
            if (cerita1.active == true)
            {
                cerita1.active = false;
                cerita2.active = true;
                cerita3.active = false;
                cerita4.active = false;
                cerita5.active = false;
                cerita6.active = false;
                soal1.active = false;
                soal2.active = false;
                soal3.active = false;
                soal4.active = false;
                btnYa.active = false;
                btnTidak.active = false;
                btnLanjut.active = true;
                btnMulai.active = false;
            }
            else if (cerita2.active == true)
            {
                cerita1.active = false;
                cerita2.active = false;
                //cerita3.active = true;
                cerita4.active = true;
                cerita5.active = false;
                cerita6.active = false;
                soal1.active = false;
                soal2.active = false;
                soal3.active = false;
                soal4.active = false;
                btnYa.active = false;
                btnTidak.active = false;
                btnLanjut.active = true;
                btnMulai.active = false;
                char1.active = true;
            }
            else if (cerita3.active == true)
            {
                cerita1.active = false;
                cerita2.active = false;
                cerita3.active = false;
                cerita4.active = true;
                cerita5.active = false;
                cerita6.active = false;
                soal1.active = false;
                soal2.active = false;
                soal3.active = false;
                soal4.active = false;
                btnYa.active = false;
                btnTidak.active = false;
                btnLanjut.active = true;
                btnMulai.active = false;
            }
            else if (cerita4.active == true)
            {
                cerita1.active = false;
                cerita2.active = false;
                cerita3.active = false;
                cerita4.active = false;
                cerita5.active = true;
                cerita6.active = false;
                soal1.active = false;
                soal2.active = false;
                soal3.active = false;
                soal4.active = false;
                btnYa.active = false;
                btnTidak.active = false;
                btnLanjut.active = true;
                btnMulai.active = false;
            }
            else if (cerita5.active == true)
            {
                cerita1.active = false;
                cerita2.active = false;
                cerita3.active = false;
                cerita4.active = false;
                cerita5.active = false;
                cerita6.active = true;
                soal1.active = false;
                soal2.active = false;
                soal3.active = false;
                soal4.active = false;
                btnYa.active = false;
                btnTidak.active = false;
                btnLanjut.active = true;
                btnMulai.active = false;
                char1.active = false;
                char2.active = true;
                musuh.active = true;
            }
            else if (cerita6.active == true)
            {
                cerita1.active = false;
                cerita2.active = false;
                cerita3.active = false;
                cerita4.active = false;
                cerita5.active = false;
                cerita6.active = false;
                soal1.active = true;
                soal2.active = false;
                soal3.active = false;
                soal4.active = false;
                btnLanjut.active = false;
                btnYa.active = true;
                btnTidak.active = true;
            }

            print("button clicked");
            MyFx.PlayOneShot(FxClick);
        }
        else if (this.gameObject.name == "btnYa")
        {
            if (soal1.active == true)
            {
                cerita1.active = false;
                cerita2.active = false;
                cerita3.active = false;
                cerita4.active = false;
                cerita5.active = false;
                cerita6.active = false;
                soal1.active = false;
                soal2.active = false;
                soal3.active = false;
                soal4.active = true;
                btnYa.active = false;
                btnTidak.active = false;
                btnMulai.active = true;
            }
            else if (soal2.active == true)
            {
                cerita1.active = false;
                cerita2.active = false;
                cerita3.active = false;
                cerita4.active = false;
                cerita5.active = false;
                cerita6.active = false;
                soal1.active = false;
                soal2.active = false;
                soal3.active = false;
                soal4.active = true;
                btnYa.active = false;
                btnTidak.active = false;
                btnMulai.active = true;
            }
            else if (soal3.active == true)
            {
                cerita1.active = false;
                cerita2.active = false;
                cerita3.active = false;
                cerita4.active = false;
                cerita5.active = false;
                cerita6.active = false;
                soal1.active = false;
                soal2.active = false;
                soal3.active = false;
                soal4.active = true;
                btnYa.active = false;
                btnTidak.active = false;
                btnMulai.active = true;
            }
            MyFx.PlayOneShot(FxClick);
        }
        else if (this.gameObject.name == "btnTidak")
        {
            if (soal1.active == true)
            {
                cerita1.active = false;
                cerita2.active = false;
                cerita3.active = false;
                cerita4.active = false;
                cerita5.active = false;
                cerita6.active = false;
                soal1.active = false;
                soal2.active = true;
                soal3.active = false;
                soal4.active = false;
                btnYa.active = true;
                btnTidak.active = true;
                btnLanjut.active = false;
                btnMulai.active = false;
            }
            else if (soal2.active == true)
            {
                cerita1.active = false;
                cerita2.active = false;
                cerita3.active = false;
                cerita4.active = false;
                cerita5.active = false;
                cerita6.active = false;
                soal1.active = false;
                soal2.active = false;
                soal3.active = true;
                soal4.active = false;
                btnYa.active = true;
                btnTidak.active = false;
                btnLanjut.active = false;
                btnMulai.active = false;
            }
            MyFx.PlayOneShot(FxClick);
        }
        else if (this.gameObject.name == "btnMulai")
        {
            MyFx.PlayOneShot(FxClick);
            Application.LoadLevel("PilihLevel");
        }

    }
}
