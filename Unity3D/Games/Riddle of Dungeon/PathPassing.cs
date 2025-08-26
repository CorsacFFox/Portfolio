using UnityEngine;
using System.Collections;
using System.Linq;
using System;

public class PathPassing : MonoBehaviour
{
    public GameObject[] waypoints;
    public float speed = 3f;
    public float rotationSpeed = 4.0f;
    private int currentWaypointIndex = 0;
    public GameObject player;
    //private GameController gc;

    private void Start()
    {
        //gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        waypoints = GameObject.FindGameObjectsWithTag("Waypoint");
        waypoints = waypoints.OrderBy(waypoint => waypoint.name).ToArray();
        StartCoroutine(gaw());
    }
    private IEnumerator gaw()
    {
        yield return new WaitForSeconds(3f);
        gameObject.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(0.5f);
        gameObject.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(2f);
        gameObject.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(0.5f);
        gameObject.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(4f);
        gameObject.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        gameObject.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(0.5f);
        gameObject.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(2f);
        gameObject.GetComponent<AudioSource>().Play();
    }
    void Update()
    {
        Move();
    }
    private IEnumerator FadeOutAndDestroy()
    {
        Vector3 originalScale = transform.localScale;
        float duration = 1.0f;
        float elapsedTime = 0f;
        while (elapsedTime < duration)
        {
            float t = elapsedTime / duration;
            transform.localScale = Vector3.Lerp(originalScale,
           Vector3.zero, t);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        Destroy(gameObject);

    }

    void Move()
    {
        if (currentWaypointIndex < waypoints.Length)
        {
            Transform targetWaypoint = waypoints[currentWaypointIndex].transform;
            Vector3 direction = targetWaypoint.position - transform.position;

            transform.position += direction.normalized * speed * Time.deltaTime;
            
            Quaternion targetRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotationSpeed);
        
            if (Vector3.Distance(transform.position, player.transform.position) > 10f)
            {
                speed = 3f;
            }
            else
            {
                speed = (currentWaypointIndex < 10) ? 3f : 7.5f;
            }
         
            if (Vector3.Distance(transform.position, targetWaypoint.position) < 0.1f)
            {
                currentWaypointIndex++;
            }
        }
        else
        {
            StartCoroutine(FadeOutAndDestroy());
        }
        
    }
}