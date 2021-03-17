using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorScr : MonoBehaviour
{
    public Texture2D cursorTexture;
    public Texture2D cursorTexture2;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    void Start()
    {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }

    void OnMouseEnter()
    {
        Cursor.SetCursor(cursorTexture2, hotSpot, cursorMode);
    }

    void OnMouseExit()
    {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }

    private void OnDestroy()
    {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }
}
