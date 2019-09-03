using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScreenBorder : MonoBehaviour
{
    private Camera cam;
    private Vector2 screenBounds;
    private float objectWidth;
    private float objectHeight;
    void Start()
    {
        cam = Camera.main;
        screenBounds = cam.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, cam.transform.position.z));
        objectHeight = GetComponent<SpriteRenderer>().bounds.extents.x;
        objectWidth = GetComponent<SpriteRenderer>().bounds.extents.y;
      }

    void LateUpdate()
    {
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x * -1 + objectWidth, screenBounds.x - objectWidth);
        viewPos.y = Mathf.Clamp(viewPos.y, screenBounds.y * -1 + objectHeight, screenBounds.y - objectHeight);
        transform.position = viewPos;
    }
}
