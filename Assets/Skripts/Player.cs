using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float BounceSpeed;
    public Rigidbody Rigidbody;
    public Game Game;
    public Platform CurrentPlatform;

   

    public void Bounce()
    {
        Rigidbody.velocity = new Vector3(0, BounceSpeed, 0);
    }
    public void Die()
    {
        Game.OnPlayerDied();
        Rigidbody.velocity = Vector3.zero;

    }

    public void ReachFinish()
    {
        Game.OnPlayerRishedFinish();
        Rigidbody.velocity = Vector3.zero;

    }
}
