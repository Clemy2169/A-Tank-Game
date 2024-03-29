using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
    [SerializeField] private float maxSpeed = 10;
    [SerializeField] private float rotationSpeed = 25;
    [SerializeField] private GameObject tete;

    
    private Transform localTransform;

    private float rotateAxis;
    private float forwardBackwardAxis;
    private Vector2 mouseVector;
    public float tetespeed;
    

    // Start is called before the first frame update
    void Start()
    {
        localTransform = GetComponent<Transform>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    private void Update()
    {
        /*
        localTransform.Rotate(Vector3.up, Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime);
        localTransform.Translate(Input.GetAxis("Vertical") * Vector3.forward * maxSpeed * Time.deltaTime);
        */
        
        localTransform.Rotate(Vector3.up, rotateAxis * rotationSpeed * Time.deltaTime);
        localTransform.Translate(Vector3.forward * Time.deltaTime * forwardBackwardAxis * maxSpeed);
        tete.transform.Rotate(Vector3.up, mouseVector.x * tetespeed * Time.deltaTime);

    }

    public void HandleRotate(InputAction.CallbackContext inputContext)
    {
        rotateAxis = inputContext.ReadValue<float>();
        Debug.Log("Rotate  = " + rotateAxis);
    }
    public void HandleForwardBackward(InputAction.CallbackContext inputContext)
    {
        forwardBackwardAxis = inputContext.ReadValue<float>();
        Debug.Log("forwardBackward  = " + forwardBackwardAxis);
    }

    public void HandleFollowMouse(InputAction.CallbackContext inputContext)
    {
        mouseVector = inputContext.ReadValue<Vector2>();
        Debug.Log(message:"FollowMouse = " + mouseVector );
        
    }


}