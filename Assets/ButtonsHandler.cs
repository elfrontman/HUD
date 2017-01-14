using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ButtonsHandler {

    public ButtonsHandler() {}

    public static void attachHandler(string nameObject, UnityAction callback) {
        try
        {
            Button _button = GameObject.Find(nameObject).GetComponent<Button>();
            _button.onClick.AddListener(callback);
        }
        catch (NullReferenceException err) { };
        
    }
}
