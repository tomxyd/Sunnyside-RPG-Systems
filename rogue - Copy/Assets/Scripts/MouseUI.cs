using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseUI : MonoBehaviour
{
     Camera mainCamera;
    private void Start()
    {
        mainCamera = Camera.main;
        Cursor.visible = false;
    }

    private void Update() {
        Vector2 cursorPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        transform.position = cursorPosition;
    }
}
