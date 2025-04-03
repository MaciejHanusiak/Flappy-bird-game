using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform target;
    Vector3 offset;
    Vector3 tempPos;
    

    void Start()
    {   //
        offset = transform.position - target.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (target != null)
        {
            tempPos = target.position + offset;
            tempPos.y = 0;
            transform.position = tempPos;
        }
    }
}
