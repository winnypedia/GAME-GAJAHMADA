using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonKuis2 : MonoBehaviour {

    public GameObject ButtonSoal1;
    public GameObject ButtonSoal2;
    public GameObject ButtonSoal3;
    public GameObject soal1;
    public GameObject soal2;
    public GameObject soal3;
    public GameObject benar1;
    public GameObject benar2;
    public GameObject benar3;
    public GameObject salahSumatra;
    public GameObject salahKalimantan;
    public GameObject salahSulawesi;
    public GameObject salahLapala;
    public GameObject salahLalapa;
    public GameObject salahPapala;
    public GameObject salah9Daerah;
    public GameObject salah11Daerah;
    public GameObject salah3Daerah;
    public GameObject buttonLanjut;
    public GameObject buttonMengerti;

    public AudioSource MyFx;
    public AudioClip FXbenar;
    public AudioClip FXsalah;
    public AudioClip FXlanjut;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

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
                ButtonSoal1.active = false;
                ButtonSoal2.active = true;
                buttonLanjut.active = false;
                salahSumatra.active = false;
                salahKalimantan.active = false;
                salahSulawesi.active = false;
                MyFx.PlayOneShot(FXlanjut);
            }
            else if (soal2.active == true)
            {
                soal2.active = false;
                soal3.active = true;
                benar2.active = false;
                ButtonSoal2.active = false;
                ButtonSoal3.active = true;
                buttonLanjut.active = false;
                salahLapala.active = false;
                salahLalapa.active = false;
                salahPapala.active = false;
                MyFx.PlayOneShot(FXlanjut);
            }
        }
        else if (this.gameObject.name == "JKalimantan")
        {
            if (soal1.active == true)
            {
                salahKalimantan.active = true;
                benar1.active = true;
                buttonLanjut.active = true;
                MyFx.PlayOneShot(FXsalah);
            }
        }
        else if (this.gameObject.name == "JSulawesi")
        {
            if (soal1.active == true)
            {
                salahSulawesi.active = true;
                benar1.active = true;
                buttonLanjut.active = true;
                MyFx.PlayOneShot(FXsalah);
            }
        }
        else if (this.gameObject.name == "JSumatra")
        {
            if (soal1.active == true)
            {
                salahSumatra.active = true;
                benar1.active = true;
                buttonLanjut.active = true;
                MyFx.PlayOneShot(FXsalah);
            }
        }
        else if (this.gameObject.name == "JPapua")
        {
            if (soal1.active == true)
            {
                benar1.active = true;
                buttonLanjut.active = true;
                MyFx.PlayOneShot(FXbenar);
            }
        }
        else if (this.gameObject.name == "J9")
        {
            if (soal3.active == true)
            {
                salah9Daerah.active = true;
                benar3.active = true;
                buttonMengerti.active = true;
                MyFx.PlayOneShot(FXsalah);
            }
        }
        else if (this.gameObject.name == "JLalapa")
        {
            salahLalapa.active = true;
            benar2.active = true;
            buttonLanjut.active = true;
            MyFx.PlayOneShot(FXsalah);
        }
        else if (this.gameObject.name == "JPapala")
        {
            salahPapala.active = true;
            benar2.active = true;
            buttonLanjut.active = true;
            MyFx.PlayOneShot(FXsalah);
        }
        else if (this.gameObject.name == "JLapala")
        {
            salahLapala.active = true;
            benar2.active = true;
            buttonLanjut.active = true;
            MyFx.PlayOneShot(FXsalah);
        }
        else if (this.gameObject.name == "JPalapa")
        {
            benar2.active = true;
            buttonLanjut.active = true;
            MyFx.PlayOneShot(FXbenar);
        }
        else if (this.gameObject.name == "J11")
        {
            if (soal3.active == true)
            {
                salah11Daerah.active = true;
                benar3.active = true;
                buttonMengerti.active = true;
                MyFx.PlayOneShot(FXsalah);
            }
        }
        else if (this.gameObject.name == "J3")
        {
            if (soal3.active == true)
            {
                salah3Daerah.active = true;
                benar3.active = true;
                buttonMengerti.active = true;
                MyFx.PlayOneShot(FXsalah);
            }
        }
        else if (this.gameObject.name == "J10")
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
