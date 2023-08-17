using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.XR.ARFoundation;
using System;

public class GameManager : MonoBehaviour
{
    /// <summary>
    /// Reference to the scenes raycast manager
    /// </summary>
    [SerializeField] ARRaycastManager raycastManager = null;

    /// <summary>
    /// The object to instantiate every time the user taps the screen at a location
    /// </summary
    [SerializeField] GameObject objectPrefab;

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            List<ARRaycastHit> hits = new List<ARRaycastHit>();

            if (touch.phase == TouchPhase.Began)
            {
                if (raycastManager.Raycast(touch.position, hits, TrackableType.PlaneWithinPolygon))
                {
                    ARRaycastHit hit = hits[0];
                    GameObject obj = Instantiate(objectPrefab, hit.pose.position, hit.pose.rotation);
                }
            }
        }
    }
}
