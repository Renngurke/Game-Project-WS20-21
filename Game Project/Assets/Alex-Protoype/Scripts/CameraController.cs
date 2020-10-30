using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] float yOffset = 25;

    [SerializeField] Transform follow;

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector3(follow.position.x, follow.position.y + yOffset, follow.position.z);
    }
}
