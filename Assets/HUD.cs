using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD{

    private GameObject mainHUD;
    private Button[] buttons;
    public enum stateHUD {Splash, Main, Settings, Winner, Loser};

    public GameObject objectHUD{
        get {
            return this.mainHUD;
        }
    }

    public HUD(){
        this.mainHUD = GameObject.Find("HUD");
        this.buttons = this.mainHUD.GetComponents<Button>();

        Debug.Log(buttons.Length);
    }

    public void manageHUD(stateHUD state) {
        this.hideHud();
        switch (state) {
            case stateHUD.Splash:
                this.mainHUD.transform.GetChild(0).gameObject.SetActive(true);
                break;
            case stateHUD.Main:
                this.mainHUD.transform.GetChild(1).gameObject.SetActive(true);
                break;
            case stateHUD.Settings:
                this.mainHUD.transform.GetChild(2).gameObject.SetActive(true);
                break;
            default:
                break;
        }
    }


    public void hideHud() {
        for(int i = 0; i < this.mainHUD.transform.childCount; i++) {
            this.mainHUD.transform.GetChild(i).gameObject.SetActive(false);
        }
    }

    public void resetHud() {
        this.hideHud();
        this.manageHUD(stateHUD.Splash);
    }

    public IEnumerator fadeView(stateHUD state, float time) {
        yield return new WaitForSeconds(time);
        this.manageHUD(state);
    }







}
