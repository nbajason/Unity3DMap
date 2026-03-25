using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{

    [SerializeField] private float speed = 10f;

    [SerializeField] private float jumpHeight = 20f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Time.deltaTime in this laptop:" + Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        } 
        else if (Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed)
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        } 
        else if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        } 
        else if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);    
        } 
        else if (Keyboard.current.spaceKey.isPressed )
        {
            // small Jumping
            
            if (Keyboard.current.shiftKey.isPressed)
            {
                // big Jumping
                transform.Translate(Vector3.up * Time.deltaTime * jumpHeight * 2);
            } else {
                transform.Translate(Vector3.up * Time.deltaTime * jumpHeight);
            }
        } 
        else if (Keyboard.current.escapeKey.isPressed)
        {
            Application.Quit();
        }
    }
}
