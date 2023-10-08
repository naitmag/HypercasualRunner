using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float sensitivity;

    private float oldMousePosition;
    private float eulerY;
    [SerializeField] Animator anim;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            oldMousePosition = Input.mousePosition.x;            
        }
        

            if (Input.GetMouseButton(0))
        {
            anim.SetBool("isRunning", true);
            anim.ResetTrigger("dance");
            Vector3 newPosition = transform.position + transform.forward * speed *Time.deltaTime;
            newPosition.x = Mathf.Clamp(newPosition.x, -2.45f, 2.45f);

            transform.position = newPosition;
            float deltaX = Input.mousePosition.x - oldMousePosition;
            oldMousePosition = Input.mousePosition.x;
            eulerY += deltaX * sensitivity;
            eulerY = Mathf.Clamp(eulerY, -70, 70);
            transform.eulerAngles = new Vector3(0, eulerY);
        }
            else
        {
            anim.SetBool("isRunning", false);
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            anim.SetTrigger("dance");            
        }
    }

}
