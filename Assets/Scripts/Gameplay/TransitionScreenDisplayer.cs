using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TransitionScreenDisplayer : MonoBehaviour
{

    public Image image;    
    public static Sprite image0start;
    public static Sprite image0correct;
    public static Sprite image0wrong;
    public static Sprite image1start;
    public static Sprite image1correct;
    public static Sprite image1wrong;
    public static Sprite image2start;
    public static Sprite image2correct;
    public static Sprite image2wrong;
    public static Sprite image3start;
    public static Sprite image3correct;
    public static Sprite image3wrong;
    public static Sprite image4start;
    public static Sprite image4correct;
    public static Sprite image4wrong;
    public static Sprite image5start;
    public static Sprite image5correct;
    public static Sprite image5wrong;
    public static Sprite image6start;
    public static Sprite image6correct;
    public static Sprite image6wrong;
    public static Sprite image7start;
    public static Sprite image7correct;
    public static Sprite image7wrong;
    public static Sprite image8start;
    public static Sprite image8correct;
    public static Sprite image8wrong;
    public static Sprite image9start;
    public static Sprite image9correct;
    public static Sprite image9wrong;
    public static Sprite image10start;
    public static Sprite image10correct;
    public static Sprite image10wrong;

    public Sprite[] images = new Sprite[]
    {
        image0start,
        image0correct,
        image0wrong,
        image1start,
        image1correct,
        image1wrong,
        image2start,
        image2correct,
        image2wrong,
        image3start,
        image3correct,
        image3wrong,
        image4start,
        image4correct,
        image4wrong,
        image5start,
        image5correct,
        image5wrong,
        image6start,
        image6correct,
        image6wrong,
        image7start,
        image7correct,
        image7wrong,
        image8start,
        image8correct,
        image8wrong,
        image9start,
        image9correct,
        image9wrong,
        image10start,
        image10correct,
        image10wrong,
    };
    
    // Start is called before the first frame update
    void Start()
    {
        image.sprite = images[2];
        StartCoroutine(FadeImage());
    }

    public void UpdateScriptWithIndex(bool isWrong, int index)
    {   
        int intWrong = isWrong ? 1 : 0;
        image.sprite = images[index * 3 + intWrong];
        StartCoroutine(FadeEndScreen(index));
       
        
    }

    IEnumerator FadeEndScreen(int index)
    {
        
        for (float i = 0; i <=2f; i += Time.deltaTime)
        {
            image.color = new Color(255, 255, 255, 1);
            yield return null;
        }
        if (index >= (images.Length / 3 - 1))
        {
            LoadCredits();
        } 
        else 
        {
            image.sprite = images[(index + 2) * 3 - 1];
            StartCoroutine(FadeImage());    
        }
        
        
    }

    IEnumerator FadeImage()
    {
        for (float i = 0; i <=3f; i += Time.deltaTime)
        {
            image.color = new Color(255, 255, 255, 1);
            yield return null;
        }

        for (float i = 0.2f; i >= 0; i -= Time.deltaTime)
        {
            // set color with i as alpha
            image.color = new Color(255, 255, 255, i * 5);
            yield return null;
        }

        image.color = new Color(255, 255, 255, 0);
    }

    void LoadCredits()
    {
        SceneManager.LoadScene("CreditsScene");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
