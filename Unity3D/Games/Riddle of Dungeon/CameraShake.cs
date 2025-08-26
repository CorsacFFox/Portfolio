using UnityEngine;
using System.Collections;

public class CameraShake : MonoBehaviour
{
    private float shakeDuration = 30f;
    private float shakeMagnitude = 0.05f;

    private Vector3 originalPosition;
    private Coroutine shakeCoroutine;
    private float elapsed = 0.0f;
    internal bool isShaking = false;

    void Start()
    {
        originalPosition = transform.localPosition;
    }

    public void TriggerShake()
    {
        if (shakeCoroutine != null)
        {
            StopCoroutine(shakeCoroutine);
        }
        shakeCoroutine = StartCoroutine(Shake());
    }

    private IEnumerator Shake()
    {
        isShaking = true;

        while (elapsed < shakeDuration)
        {
            float magnitude = shakeMagnitude * (1 - (elapsed / shakeDuration));
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            transform.localPosition = new Vector3(originalPosition.x + x, originalPosition.y + y, originalPosition.z);

            elapsed += Time.deltaTime;
            yield return null;
        }

        transform.localPosition = originalPosition;
        isShaking = false;
    }
    public void pause_earthquake()
    {
        if (isShaking)
        {
            StopCoroutine(shakeCoroutine);
            isShaking = false;
        }      
    }
    private void Update()
    {
        if (isShaking)
        {
            
        }
    }
}

//using UnityEngine;
//using System.Collections;
//using System;

//public class CameraShake : MonoBehaviour
//{
//    private float shakeDuration = 30f;
//    private float shakeMagnitude = 0.05f;

//    private Vector3 originalPosition;

//    void Start()
//    {
//        originalPosition = transform.localPosition;
//    }

//    public void TriggerShake()
//    {
//        StartCoroutine(Shake());
//    }

//    private IEnumerator Shake()
//    {
//        float elapsed = 0.0f;

//        while (elapsed < shakeDuration)
//        {
//            float magnitude = shakeMagnitude * (1 - (elapsed / shakeDuration));
//            float x = UnityEngine.Random.Range(-1f, 1f) * magnitude;
//            float y = UnityEngine.Random.Range(-1f, 1f) * magnitude;

//            transform.localPosition = new Vector3(originalPosition.x + x, originalPosition.y + y, originalPosition.z);

//            elapsed += Time.deltaTime;
//            yield return null;
//        }

//        transform.localPosition = originalPosition;
//    }
//    private void Update()
//    {


//    }
//}