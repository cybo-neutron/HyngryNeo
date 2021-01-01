using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum types
{
    stationary,moving,AI
}

public enum attackSkills
{
    melle,shooting
}

public enum states
{
    idle,patrol,chase,attack
}

public abstract class Enemy : MonoBehaviour
{
    public types type;
    public attackSkills attackSkill;
    public states state;

    #region State Related
    [Header("State Related")]
    public GameObject whoisPlayer;
    public LayerMask playerLayer;

    float distanceFromPlayer;
    public float chasingDistance;
    public float attackingDistance;
    public float rayCastLength;
    public Transform[] Waypoints;

    #endregion


    #region Characteristics
    [Header("Characteristics")]
    public int health;
    public float speed;
    public float fireRate;
    float nextFireTime;
    #endregion

    public virtual void Start()
    {
        if(whoisPlayer==null)
        {
            whoisPlayer = GameObject.FindGameObjectWithTag("Player");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(type == types.stationary)
        {
            //horizontal rayCast
            Debug.DrawRay(transform.position, transform.right*rayCastLength, Color.blue);


        }
        else if(type == types.AI)
        {
            //rayCast to the player
        }
        else
        {
            //moving Enemy switch b/w idle and patrol
        }


        switch(state)
        {
            case states.idle:
                idle();
                break;
            case states.patrol:
                patrol();
                break;
            case states.chase:
                chase();
                break;
            case states.attack:
                attack();
                break;
            default:
                patrol();
                break;
        }
        
    }

    public abstract void patrol();
    public abstract void idle();
    public abstract void chase();
    public abstract void attack();

}
