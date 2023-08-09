
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorManager : MonoBehaviour
{
    Animator animator;
    int vertical, horizontal;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        horizontal = Animator.StringToHash("Horizontal");
        vertical = Animator.StringToHash("Vertical");
    }
    public void UpdateAnimatorVAlues(float honrizontalMovement, float verticalMovement)
    {
        float snappedHorizontal;
        float snappedVertical;
        #region snappedHorizontal
        if (honrizontalMovement > 0 && honrizontalMovement < 0.55f)
        {
            snappedHorizontal = 0.5f;
        }
        else if(honrizontalMovement > 0.55f)
        {
            snappedHorizontal = 1;
        }
        else if (honrizontalMovement < 0 && honrizontalMovement > -0.55f)
        {
            snappedHorizontal = -0.5f;
        }
        else if(honrizontalMovement < -0.55f)
        {
            snappedHorizontal = -1;
        }
        else
        {
            snappedHorizontal = 0;
        }
        #endregion

        #region snappedVertical
        if (verticalMovement > 0 && verticalMovement < 0.55f)
        {
            snappedVertical = 0.5f;
        }
        else if (verticalMovement > 0.55f)
        {
            snappedVertical = 1;
        }
        else if (verticalMovement < 0 && verticalMovement > -0.55f)
        {
            snappedVertical = -0.5f;
        }
        else if (verticalMovement < -0.55f)
        {
            snappedVertical = -1;
        }
        else
        {
            snappedVertical = 0;
        }
        #endregion
        animator.SetFloat(horizontal, snappedHorizontal, 0.1f, Time.deltaTime);
        animator.SetFloat(vertical, snappedVertical, 0.1f, Time.deltaTime);

    }
}
