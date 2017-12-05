using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour {

    [SerializeField]
    private float speed;

    protected Vector2 direction;

    [SerializeField]
    private Animator animator;

    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	protected virtual void Update () {
        Move();
    }

    public void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);

        if (direction.x != 0 || direction.y!=0)
        {
            AnimateMovement();
        }
        else
        {
            animator.SetLayerWeight(1, 0);
        }
        
    }

    public void AnimateMovement()
    {
        animator.SetLayerWeight(1, 1);

        animator.SetFloat("X", direction.x);
        animator.SetFloat("Y", direction.y);
    }
}
