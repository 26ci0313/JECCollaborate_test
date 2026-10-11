using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(CapsuleCollider))]
public class Charactor_controll : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] int runspeed = 5;
    [SerializeField] int jumpforce = 5;
    Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = rb.GetComponent<Animator>();
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
            animator.SetTrigger("jump");
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            Vector3 target = new Vector3(180, 0, 0);
            transform.LookAt(target);
            rb.AddForce(Vector3.right * runspeed, ForceMode.Force);
            animator.SetTrigger("run");
        }
        else if (Keyboard.current.aKey.isPressed)
        {
            Vector3 target = new Vector3(-180, 0, 0);
            transform.LookAt(target);
            rb.AddForce(Vector3.left * runspeed, ForceMode.Force);
            animator.SetTrigger("run");
        }
        else
        {
            animator.SetTrigger("idol");
        }
    }
}
