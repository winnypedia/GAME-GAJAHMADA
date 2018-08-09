using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandlerr : MonoBehaviour {
    public GameObject lv1;
    public GameObject lv2;
    public GameObject lv3;
    public GameObject lv4;
    public GameObject lv5;
    public GameObject btnKiri;
    public GameObject btnKanan;
    public GameObject infolv1;
    public GameObject infolv2;
    public GameObject infolv3;
    public GameObject btnMulai;

    public AudioSource MyFx;
    public AudioClip FxClick;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ButtonClick()
    {
        if (this.gameObject.name == "ButtonKanan")
        {

            if(lv1.active == true)
            {
                lv1.active = false;
                lv2.active = true;
                lv3.active = false;
                lv4.active = false;
                lv5.active = false;
                btnKiri.active = true;
                btnKanan.active = true;
                infolv1.active = false;
                infolv2.active = false;
                infolv3.active = false;
                btnMulai.active = false;
            }
            else if (lv2.active == true)
            {
                lv1.active = false;
                lv2.active = false;
                lv3.active = true;
                lv4.active = false;
                lv5.active = false;
                btnKiri.active = true;
                btnKanan.active = true;
                infolv1.active = false;
                infolv2.active = false;
                infolv3.active = false;
                btnMulai.active = false;
            }
            else if (lv3.active == true)
            {
                lv1.active = false;
                lv2.active = false;
                lv3.active = false;
                lv4.active = true;
                lv5.active = false;
                btnKiri.active = true;
                btnKanan.active = true;
                infolv1.active = false;
                infolv2.active = false;
                infolv3.active = false;
                btnMulai.active = false;
            }
            else if (lv4.active == true)
            {
                lv1.active = false;
                lv2.active = false;
                lv3.active = false;
                lv4.active = false;
                lv5.active = true;
                btnKiri.active = true;
                btnKanan.active = false;
                infolv1.active = false;
                infolv2.active = false;
                infolv3.active = false;
                btnMulai.active = false;
            }
        }
        else if (this.gameObject.name == "ButtonKiri")
        {

            if (lv2.active == true)
            {
                lv1.active = true;
                lv2.active = false;
                lv3.active = false;
                lv4.active = false;
                lv5.active = false;
                btnKiri.active = false;
                btnKanan.active = true;
                infolv1.active = false;
                infolv2.active = false;
                infolv3.active = false;
                btnMulai.active = false;
            }
            else if (lv3.active == true)
            {
                lv1.active = false;
                lv2.active = true;
                lv3.active = false;
                lv4.active = false;
                lv5.active = false;
                btnKiri.active = true;
                btnKanan.active = true;
                infolv1.active = false;
                infolv2.active = false;
                infolv3.active = false;
                btnMulai.active = false;
            }
            else if (lv4.active == true)
            {
                lv1.active = false;
                lv2.active = false;
                lv3.active = true;
                lv4.active = false;
                lv5.active = false;
                btnKiri.active = true;
                btnKanan.active = true;
                infolv1.active = false;
                infolv2.active = false;
                infolv3.active = false;
                btnMulai.active = false;
            }
            else if (lv5.active == true)
            {
                lv1.active = false;
                lv2.active = false;
                lv3.active = false;
                lv4.active = true;
                lv5.active = false;
                btnKiri.active = true;
                btnKanan.active = true;
                infolv1.active = false;
                infolv2.active = false;
                infolv3.active = false;
                btnMulai.active = false;
            }
        }
        else if (this.gameObject.name == "level1")
        {
            if (lv1.active == true)
            {
                lv1.active = true;
                lv2.active = false;
                lv3.active = false;
                lv4.active = false;
                lv5.active = false;
                btnKiri.active = false;
                btnKanan.active = true;
                infolv1.active = true;
                infolv2.active = false;
                infolv3.active = false;
                btnMulai.active = true;
            }
        }
        else if (this.gameObject.name == "level2")
        {
            if (lv2.active == true)
            {
                lv1.active = false;
                lv2.active = true;
                lv3.active = false;
                lv4.active = false;
                lv5.active = false;
                btnKiri.active = true;
                btnKanan.active = true;
                infolv1.active = false;
                infolv2.active = true;
                infolv3.active = false;
                btnMulai.active = true;
            }
        }
        else if (this.gameObject.name == "level3")
        {
            if (lv3.active == true)
            {
                lv1.active = false;
                lv2.active = false;
                lv3.active = true;
                lv4.active = false;
                lv5.active = false;
                btnKiri.active = true;
                btnKanan.active = true;
                infolv1.active = false;
                infolv2.active = false;
                infolv3.active = true;
                btnMulai.active = true;
            }
        }
        else if (this.gameObject.name == "ButtonMulai")
        {
            print("Pitko Muda");
            if (lv1.active == true)
            {
                Application.LoadLevel("MainLevel");
            }
            else if (lv2.active == true)
            {
                Application.LoadLevel("Level2");
            }
            else if (lv3.active == true)
            {
                Application.LoadLevel("Level3");
            }
        }
        else if (this.gameObject.name == "ButtonKembali")
        {
            Application.LoadLevel("Title Menu");
        }

        MyFx.PlayOneShot(FxClick);
    }
}
