using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TankData))]
[RequireComponent(typeof(TankMotor))]
public class InputManager : MonoBehaviour
{
    private TankMotor motor;
    private TankData data;
    public enum InputScheme { WASD, arrowKeys };
    public InputScheme input = InputScheme.WASD;
    // Start is called before the first frame update
    void Start()
    {
        motor = gameObject.GetComponent<TankMotor>();
        data = gameObject.GetComponent<TankData>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleInput();
    }

    void HandleInput()
    {
        switch (input)
        {
            case InputScheme.arrowKeys:
                // Handle movement
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    motor.Move(data.moveSpeed);
                }
                else if (Input.GetKey(KeyCode.DownArrow))
                {
                    motor.Move(-data.moveSpeed);
                }
                else
                {
                    motor.Move(0);
                }

                // Handle rotation
                if (Input.GetKey(KeyCode.RightArrow))
                {
                    motor.Rotate(data.rotateSpeed);
                }

                break;
            case InputScheme.WASD:
                if (Input.GetKey(KeyCode.W))
                {
                    motor.Move(data.moveSpeed);
                }
                break;
            default:
                Debug.LogError("[InputManager] Undefined input scheme.");
                break;
        }
    }
}
