using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
//using UnityEngine.Rendering.PostProcessing;
using UnityEngine.Rendering.Universal;
public class TextController : MonoBehaviour
{
    public Volume volume;
    private Vignette vignette;

    [SerializeField] private float targetIntensity = 0.265f;
    [SerializeField] private float duration = 0.5f;
    private bool textShowed = false;
    
    private float elapsedTime;


    public TMP_Text dialog_field;
    public TMP_Text task_text;
    private Color color;

    // Start is called before the first frame update
    void Start()
    {
        if (volume.profile.TryGet<Vignette>(out vignette))
        {
            vignette.intensity.value = 0f;
        }       
      
        color = dialog_field.color;
        color.a = 0;
        dialog_field.color = color;
    }
    public void ShowTask(string text)
    {
        task_text.enabled = true;
        task_text.text = text;
    }

    public void HideTask() 
    {
        task_text.enabled = true;
    }
    public void ShowTextAndVignette(string text, float fullDuration, string text_color)
    {
        switch (text_color)
        {
            case "White":
                Debug.Log("White");   
                dialog_field.color = Color.white; break;
            case "Orange":
                Debug.Log("Orange");
                dialog_field.color = new Color(1f, 0.647f, 0f); break;
        }
        dialog_field.text = text;
        StartCoroutine(ChangeIntensity(fullDuration));
    }
    private IEnumerator ChangeIntensity(float fullDuration)
    {
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            vignette.intensity.value = Mathf.Lerp(0, 0.265f, elapsedTime / duration);
            color = dialog_field.color;
            color.a = Mathf.Lerp(0, 1, elapsedTime / duration);
            dialog_field.color = color;
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        
        //vignette.intensity.value = 0.265f;
        
        yield return new WaitForSeconds(fullDuration);
        elapsedTime = 0f;
        while (elapsedTime < fullDuration)
        {
            vignette.intensity.value = Mathf.Lerp(0.265f, 0, elapsedTime / fullDuration);
            color = dialog_field.color;
            color.a = Mathf.Lerp(1, 0, elapsedTime / fullDuration);
            dialog_field.color = color;
            elapsedTime += Time.deltaTime;
            yield return null;
        }
       
        vignette.intensity.value = 0;
        Color finalColor = dialog_field.color;
        finalColor.a = 0;
        dialog_field.color = finalColor;
    }
    // Update is called once per frame
    void Update()
    {    

    }
}
