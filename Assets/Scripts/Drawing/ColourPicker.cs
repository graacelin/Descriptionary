using System.Collections;
using System.Collections.Generic;

using System;
using System.IO;

using UnityEngine;
using UnityEngine.UI;

public class ColourPicker : MonoBehaviour
{   
    [SerializeField]
    private MouseDraw MouseDrawComponent;

    [SerializeField]
    private Button redButton, orangeButton, yellowButton, greenButton, blueButton, magentaButton, blackButton, clearButton;

    [SerializeField]
    private Toggle eraser;

    // Start is called before the first frame update
    void Start()
    {
        MouseDrawComponent.SetPenColour(Color.red);
        MouseDrawComponent.SetPenRadius(4);
        redButton.onClick.AddListener(OnRedPressed);
        orangeButton.onClick.AddListener(OnOrangePressed);
        yellowButton.onClick.AddListener(OnYellowPressed);
        greenButton.onClick.AddListener(OnGreenPressed);
        blueButton.onClick.AddListener(OnBluePressed);
        magentaButton.onClick.AddListener(OnMagentaPressed);
        blackButton.onClick.AddListener(OnBlackPressed);
        eraser.onValueChanged.AddListener(OnEraserToggled);
        clearButton.onClick.AddListener(OnClearPressed);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnPenColourChanged(Color32 colour)
    {
        MouseDrawComponent.SetPenColour(colour);
    }

    private void OnRedPressed()
    {
        MouseDrawComponent.SetPenColour(Color.red);
        eraser.SetIsOnWithoutNotify(false); 
        MouseDrawComponent.SetIsEraser(false);
    }

    private void OnOrangePressed()
    {
        MouseDrawComponent.SetPenColour(new Color32(255, 160, 0, 255));
        eraser.SetIsOnWithoutNotify(false); 
        MouseDrawComponent.SetIsEraser(false);
    }

    private void OnYellowPressed()
    {
        MouseDrawComponent.SetPenColour(Color.yellow);
        eraser.SetIsOnWithoutNotify(false); 
        MouseDrawComponent.SetIsEraser(false);
    }

    private void OnGreenPressed()
    {
        MouseDrawComponent.SetPenColour(Color.green);
        eraser.SetIsOnWithoutNotify(false); 
        MouseDrawComponent.SetIsEraser(false);
    }

    private void OnBluePressed()
    {
        MouseDrawComponent.SetPenColour(Color.blue);
        eraser.SetIsOnWithoutNotify(false); 
        MouseDrawComponent.SetIsEraser(false);
    }

    private void OnMagentaPressed()
    {
        MouseDrawComponent.SetPenColour(Color.magenta);
        eraser.SetIsOnWithoutNotify(false); 
        MouseDrawComponent.SetIsEraser(false);
    }

    private void OnBlackPressed()
    {
        MouseDrawComponent.SetPenColour(Color.black);
        eraser.SetIsOnWithoutNotify(false); 
        MouseDrawComponent.SetIsEraser(false);
    }

    private void OnClearPressed()
    {
        MouseDrawComponent.ClearTexture();
    }


    private void OnEraserToggled(bool value)
    {
        MouseDrawComponent.IsEraser = value;
    }
}
