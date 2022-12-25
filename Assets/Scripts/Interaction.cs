using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class Interaction : MonoBehaviour
{
    [SerializeField] private float _rayCastDistance;
    
    private void Update()
    {
        var height = 1;
        var reyCastPosition = new Vector3(transform.position.x, transform.position.y + height, transform.position.z);
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Physics.Raycast(reyCastPosition, transform.forward,out RaycastHit hit, _rayCastDistance))
            {
                if(hit.collider.gameObject.TryGetComponent<Door>(out Door door))
                {
                    door.Open();
                }
            }
            Debug.DrawRay(reyCastPosition, transform.forward, Color.red, 10);
        }
    }
}
