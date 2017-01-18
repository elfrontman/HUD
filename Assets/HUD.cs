using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD{

    private GameObject mainHUD;
    public enum stateHUD {Splash, Main, Settings, Winner, Loser};


    public GameObject objectHUD{
        get {
            return this.mainHUD;
        }
    }

    public HUD(){
        this.mainHUD = GameObject.Find("HUD");
        this.bindEvents();
        
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
        bindEvents();
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

    void bindEvents() {
        ButtonsHandler.attachHandler("btnIniciar", () => { manageHUD(stateHUD.Main); });
        ButtonsHandler.attachHandler("btnConfiguracion", () => { manageHUD(stateHUD.Settings); });
        ButtonsHandler.attachHandler("btnSalir", () => { Debug.Log("Salir"); Application.Quit(); });
        ButtonsHandler.attachHandler("btnCancelar", () => { manageHUD(stateHUD.Main); });
    }


}
