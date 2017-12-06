using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{

    /// <summary>
    /// character stats
    /// </summary>

    [SerializeField]
    private Stats health;
    [SerializeField]
    private Stats mana;
    [SerializeField]
    private Stats experience;

    [SerializeField]
    private float healthMaxValue;

    [SerializeField]
    private float manaMaxValue;


    // Use this for initialization

    protected override void Start()
    {
        health.Initialize(healthMaxValue, healthMaxValue);
        mana.Initialize(manaMaxValue, manaMaxValue);
        base.Start();
    }
	
	// Update is called once per frame
	protected override void Update () {
        GetInput();

        base.Update();
	}
    
    private void GetInput()
    {
        direction = Vector2.zero;

        //DEBUG ONLY
        if (Input.GetKeyDown(KeyCode.I))
        {
            health.CurrentValue -= 5;
            mana.CurrentValue -= 5;
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            health.CurrentValue += 5;
            mana.CurrentValue += 5;

        }


        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector2.left;
        }

        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector2.right;
        }

        if (Input.GetKey(KeyCode.W))
        {
            direction += Vector2.up;
        }

        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector2.down;
        }
    }
}
