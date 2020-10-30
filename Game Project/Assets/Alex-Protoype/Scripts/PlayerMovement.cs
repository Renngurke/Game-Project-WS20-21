using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] CharacterController controller;
    [SerializeField] Camera cam;

    [SerializeField] float movementSpeed = 10f;

    Vector3 movement = new Vector3(0f, 0f, 0f);
    Vector3 mousePos;

    private void Update()
    {
        movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;
        
        mousePos = Input.mousePosition;
    }
    
    void FixedUpdate()
    {
        controller.Move(movement * movementSpeed * Time.fixedDeltaTime);

        Vector3 lookDir = mousePos - cam.WorldToScreenPoint(transform.position);
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90;
        transform.rotation = Quaternion.AngleAxis(-angle, Vector3.up);
    }
}
