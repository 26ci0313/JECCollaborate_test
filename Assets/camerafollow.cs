using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public Transform Player;
    public float smoothSpeed = 5;
    public Vector3 offset=new Vector3 (0f, 3f, -10f);

    void LateUpdate()
    {
        Vector3 targetPosition = Player.position + offset;

        transform.position=Vector3.Lerp(
            transform.position,
            targetPosition,
            smoothSpeed * Time.deltaTime 
        );
    }
}
