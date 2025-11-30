
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Animator))]
public class CharacterAnimations : MonoBehaviour
{
    public Animator characterAnimator;

    private void Awake()
    {
        characterAnimator = GetComponent<Animator>();
    }

    public void OnJump(InputValue value)
    {
        Debug.Log("Jump pressed!");

        if (value.isPressed)
        {
            characterAnimator.SetTrigger("Jump");
        }
    }
}