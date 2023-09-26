using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BunnyOutfitter : MonoBehaviour
{
    public Image image;   
    public static Sprite image0;
    public static Sprite image1;
    public static Sprite image2;
    public static Sprite image3;
    public static Sprite image4;
    public static Sprite image5;
    public static Sprite image6;
    public static Sprite image7;
    public static Sprite image8;
    public static Sprite image9;
    public static Sprite image10;

    public Sprite[] images = new Sprite[]
    {
        image0,
        image1,
        image2,
        image3,
        image4,
        image5,
        image6,
        image7,
        image8,
        image9,
        image10
    };
    
    // Start is called before the first frame update
    void Start()
    {
        image.color = new Color(255,255,255,0);
    }

    public void UpdateAccessoryWithIndex(int index) {
        image.color = new Color(255,255,255,255);
        image.sprite = images[index];
    }
}
