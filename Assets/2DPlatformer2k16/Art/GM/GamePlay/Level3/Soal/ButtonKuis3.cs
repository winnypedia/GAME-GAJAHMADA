using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonKuis3 : MonoBehaviour {

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
    public GameObject salahPapua;
    public GameObject salahSulawesi;
    public GameObject salahBrawijaya;
    public GameObject salahSingha;
    public GameObject salahWarma;
    public GameObject salahRatu;
    public GameObject salahAbdi;
    public GameObject salahPrajurit;
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
                salahPapua.active = false;
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
                salahBrawijaya.active = false;
                salahSingha.active = false;
                salahWarma.active = false;
                MyFx.PlayOneShot(FXlanjut);
            }
        }
        else if (this.gameObject.name == "JKalimantan")
        {
            if (soal1.active == true)
            {
                benar1.active = true;
                buttonLanjut.active = true;
                MyFx.PlayOneShot(FXbenar);
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
                salahPapua.active = true;
                buttonLanjut.active = true;
                MyFx.PlayOneShot(FXsalah);
            }
        }
        else if (this.gameObject.name == "JRatu")
        {
            if (soal3.active == true)
            {
                salahRatu.active = true;
                benar3.active = true;
                buttonMengerti.active = true;
                MyFx.PlayOneShot(FXsalah);
            }
        }
        else if (this.gameObject.name == "JBrawijaya")
        {
            salahBrawijaya.active = true;
            benar2.active = true;
            buttonLanjut.active = true;
            MyFx.PlayOneShot(FXsalah);
        }
        else if (this.gameObject.name == "JSinghadawala")
        {
            salahSingha.active = true;
            benar2.active = true;
            buttonLanjut.active = true;
            MyFx.PlayOneShot(FXsalah);
        }
        else if (this.gameObject.name == "JWarmadewa")
        {
            salahWarma.active = true;
            benar2.active = true;
            buttonLanjut.active = true;
            MyFx.PlayOneShot(FXsalah);
        }
        else if (this.gameObject.name == "JMulawarmman")
        {
            benar2.active = true;
            buttonLanjut.active = true;
            MyFx.PlayOneShot(FXbenar);
        }
        else if (this.gameObject.name == "JAbdi")
        {
            if (soal3.active == true)
            {
                salahAbdi.active = true;
                benar3.active = true;
                buttonMengerti.active = true;
                MyFx.PlayOneShot(FXsalah);
            }
        }
        else if (this.gameObject.name == "JPrajurit")
        {
            if (soal3.active == true)
            {
                salahPrajurit.active = true;
                benar3.active = true;
                buttonMengerti.active = true;
                MyFx.PlayOneShot(FXsalah);
            }
        }
        else if (this.gameObject.name == "JPatih")
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
