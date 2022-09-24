using UnityEngine;
using System.Collections.Generic;

public class InventoryController : MonoBehaviour
{
    private bool isOpened = false;
    public GameObject UIPanel;
    //public List<T> itemList = new List<T>();
    void Start()
    {
        UIPanel.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            isOpened = !isOpened;
            bool state = isOpened;
            UIPanel.SetActive(state);
            CursorChangeState(state);
            CharacterMoving.isMove = !state;
            CameraController.isMove = !state;
        }

    }
    private void CursorChangeState(bool state)
    {
        Cursor.lockState = state ? CursorLockMode.None : CursorLockMode.Locked;
        Cursor.visible = state;
    }
}
