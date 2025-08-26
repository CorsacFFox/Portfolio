using UnityEngine;

public class CameraBob : MonoBehaviour
{
    //[SerializeField] private KeyCode runKey = KeyCode.LeftShift;
    //private bool isRunning;


    public float bobAmount = 0.1f;
    public float bobSpeed = 2f;

    private float originalY;
    private float timer = 0f;

    void Start()
    {
        originalY = transform.localPosition.y;
    }

    void Update()
    {
        timer += Time.deltaTime * bobSpeed;
       
        float newY = originalY + Mathf.Sin(timer) * bobAmount;

        transform.localPosition = new Vector3(transform.localPosition.x, newY, transform.localPosition.z);
    }
}