using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private bool isOpen = false;
    [SerializeField] private Quaternion _openState;
    [SerializeField] private Quaternion _closeState;

    private void Update()
    {
        if (isOpen)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, _closeState, Time.deltaTime);
        }
        else
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, _openState, Time.deltaTime);
        }
    }

    public void Open()
    {
        isOpen = !isOpen;
    }

    
}
