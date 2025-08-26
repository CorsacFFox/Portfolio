using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandHint : MonoBehaviour
{
    public Camera cam;
    public Level3Controller L3C;

    private bool canGiveHint = false;
    private float shrinkFactor = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(giveHint());
    }
    private IEnumerator giveHint()
    {
        yield return new WaitForSeconds(1.5f);
        canGiveHint = true;
    }
    bool IsObjectVisible(GameObject obj)
    {
        Vector3 directionToTarget = obj.transform.position - cam.transform.position;
        if (Physics.Raycast(cam.transform.position, directionToTarget.normalized, out RaycastHit hit))
        {
            if (hit.collider.gameObject != obj)
            {
                return false;
            }
        }
        Plane[] originalPlanes = GeometryUtility.CalculateFrustumPlanes(cam);
        Plane[] shrunkPlanes = new Plane[originalPlanes.Length];

        for (int i = 0; i < originalPlanes.Length; i++)
        {
            Vector3 normal = originalPlanes[i].normal;
            float distance = originalPlanes[i].distance * shrinkFactor;

            shrunkPlanes[i] = new Plane(normal, distance);
        }

        Collider collider = obj.GetComponent<Collider>();
        return GeometryUtility.TestPlanesAABB(shrunkPlanes, collider.bounds);
    }

    // Update is called once per frame
    void Update()
    {
        if (IsObjectVisible(gameObject) && canGiveHint)
        {
            Debug.Log("Giving a hint");
            L3C.giveHintAboutHand();
            canGiveHint = false;
        }
        
    }
}
