using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float inputHorizontal = 0f;
    public float inputVertical = 0f;
    public float velocidad = 5f;
    public PlayerMovement movimiento;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        inputVertical = Input.GetAxisRaw("Jump");
        movimiento.Move(inputHorizontal * velocidad * Time.deltaTime);
        if(inputVertical > 0f)
        {
            movimiento.Jump();
        }
    }
}
