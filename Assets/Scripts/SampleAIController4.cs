using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleAIController4 : MonoBehaviour
{
    public enum AIPersonality
    {
        Cautious,
        Aggressive
    }
    public enum AIState
    {
        Patrol,
        WaitForBackup,
        Advance,
        Attack,
        Flee
    }

    public AIPersonality currentPersonality;
    private AIState currentAIState;
    public AIState previousAIState;
    private TankData data;
    private TankMotor motor;
    public Transform target;
    private Transform tf;

    public float stateEnterTime;

    private void Start()
    {
        data = GetComponent<TankData>();
        motor = GetComponent<TankMotor>();
        tf = GetComponent<Transform>();
    }
    private void Update()
    {
        switch (currentPersonality)
        {
            case AIPersonality.Cautious:
                currentAIState = AIState.Patrol;
                CautiousTankFSM();
                break;
            case AIPersonality.Aggressive:
                // do the state machine
                break;
            default:
                Debug.LogWarning("Unimplemented personality");
                break;
        }
    }

    public void ChangeState(AIState newState)
    {
        // Save the previous state.
        previousAIState = currentAIState;

        // Change to new state.
        currentAIState = newState;

        // Save the time we changed states at.
        stateEnterTime = Time.time;
    }

    private void CautiousTankFSM()
    {
        switch (currentAIState)
        {
            case AIState.Patrol:
                Patrol();
                // Check for transitions
                // Should we flee?
                if (CheckForFlee())
                {
                    Flee();
                }
                // Should we wait for backup?
                break;
            case AIState.Advance:
                break;
        }
    }

    private void Flee()
    {
        Vector3 vectorToTarget = target.position - tf.position;
        Vector3 vectorAwayFromTarget = -vectorToTarget;

        vectorAwayFromTarget.Normalize();
        Vector3 fleePosition = vectorAwayFromTarget + tf.position;
        motor.RotateTowards(fleePosition, data.rotateSpeed);
        motor.Move(data.moveSpeed);
    }

    private void Patrol()
    {
        // Do the patrol behaviors
    }

    private bool CheckForFlee()
    {
        // TODO: Implement check for flee.
        return false;
    }
}
