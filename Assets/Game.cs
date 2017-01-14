using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour {

	private HUD mainHud;
    

    private void Awake(){
        mainHud = new HUD();
    }

    void Start () {
        mainHud.manageHUD(HUD.stateHUD.Splash);
        StartCoroutine(mainHud.fadeView(HUD.stateHUD.Main, 5f));
    }
	
	void Update () {
        
	}

    public void changeScreen(HUD.stateHUD state) {
    }
}
