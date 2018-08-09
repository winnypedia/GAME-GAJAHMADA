using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonKuis : MonoBehaviour {

    public GameObject ButtonSoal1;
    public GameObject ButtonSoal2;
    public GameObject ButtonSoal3;
    public GameObject soal1;
    public GameObject soal2;
    public GameObject soal3;
    public GameObject benar1;
    public GameObject benar2;
    public GameObject benar3;
    public GameObject salahMadura;
    public GameObject salahBali;
    public GameObject salahJawa;
    public GameObject salahLombok;
    public GameObject salahJabung;
    public GameObject salahArya;
    public GameObject salahLembu;
    public GameObject buttonLanjut;
    public GameObject buttonMengerti;

    public AudioSource MyFx;
    public AudioClip FXbenar;
    public AudioClip FXsalah;
    public AudioClip FXlanjut;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ButtonClick()
    {
        if (this.gameObject.name == "ButtonLanjut")
        {
            if (soal1.active == true)
            {
                soal1.active = false;
                soal2.active = true;
                benar1.active = false;
                ButtonSoal1.active = true;
                buttonLanjut.active = false;
                salahJawa.active = false;
                salahLombok.active = false;
                salahBali.active = false;
                salahMadura.active = false;
                MyFx.PlayOneShot(FXlanjut);
            }
            else if (soal2.active == true)
            {
                soal2.active = false;
                soal3.active = true;
                benar2.active = false;
                ButtonSoal1.active = false;
                ButtonSoal3.active = true;
                buttonLanjut.active = false;
                salahJawa.active = false;
                salahLombok.active = false;
                salahBali.active = false;
                salahMadura.active = false;
                MyFx.PlayOneShot(FXlanjut);
            }
        }
        else if (this.gameObject.name == "JMadura")
        {
            if (soal1.active == true)
            {
                salahMadura.active = true;
                benar1.active = true;
                buttonLanjut.active = true;
                MyFx.PlayOneShot(FXsalah);
            }
            else if (soal2.active == true)
            {
                salahMadura.active = true;
                benar2.active = true;
                buttonLanjut.active = true;
                MyFx.PlayOneShot(FXsalah);
            }
        }
        else if (this.gameObject.name == "JJawa")
        {
            if (soal1.active == true)
            {
                salahJawa.active = true;
                benar1.active = true;
                buttonLanjut.active = true;
                MyFx.PlayOneShot(FXsalah);
            }
            else if (soal2.active == true)
            {
                salahJawa.active = true;
                benar2.active = true;
                buttonLanjut.active = true;
                MyFx.PlayOneShot(FXsalah);
            }
        }
        else if (this.gameObject.name == "JLombok")
        {
            if (soal1.active == true)
            {
                salahLombok.active = true;
                benar1.active = true;
                buttonLanjut.active = true;
                MyFx.PlayOneShot(FXsalah);
            }
            else if (soal2.active == true)
            {
                benar2.active = true;
                buttonLanjut.active = true;
                MyFx.PlayOneShot(FXbenar);
            }
        }
        else if (this.gameObject.name == "JBali")
        {
            if (soal1.active == true)
            {
                benar1.active = true;
                buttonLanjut.active = true;
                MyFx.PlayOneShot(FXbenar);
            }
            else if (soal2.active == true)
            {
                salahBali.active = true;
                benar2.active = true;
                buttonLanjut.active = true;
                MyFx.PlayOneShot(FXsalah);
            }
        }
        else if (this.gameObject.name == "JArya")
        {
            if (soal3.active == true)
            {
                salahArya.active = true;
                benar3.active = true;
                buttonMengerti.active = true;
                MyFx.PlayOneShot(FXsalah);
            }
        }
        else if (this.gameObject.name == "JLembu")
        {
            if (soal3.active == true)
            {
                salahLembu.active = true;
                benar3.active = true;
                buttonMengerti.active = true;
                MyFx.PlayOneShot(FXsalah);
            }
        }
        else if (this.gameObject.name == "JJabung")
        {
            if (soal3.active == true)
            {
                salahJabung.active = true;
                benar3.active = true;
                buttonMengerti.active = true;
                MyFx.PlayOneShot(FXsalah);
            }
        }
        else if (this.gameObject.name == "JKembar")
        {
            if (soal3.active == true)
            {
                benar3.active = true;
                buttonMengerti.active = true;
                MyFx.PlayOneShot(FXbenar);
            }
        }
        else if (this.gameObject.name == "ButtonMengerti")
        {
            MyFx.PlayOneShot(FXlanjut);
            Application.LoadLevel("PilihLevel");
        }
    }
}
