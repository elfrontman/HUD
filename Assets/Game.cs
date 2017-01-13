using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {

	private HUD mainHud;

    private void Awake(){
        mainHud = new HUD();
    }

    void Start () {
        mainHud.manageHUD(HUD.stateHUD.Splash);
    }
	
	void Update () {
        StartCoroutine(mainHud.fadeView(HUD.stateHUD.Main, 5f));
	}

    public void changeScreen(HUD.stateHUD state) {
    }
}
