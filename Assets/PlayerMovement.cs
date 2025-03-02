using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller; 
    public float speed = 5f; 

    void Start()
    {
        controller = GetComponent<CharacterController>(); 
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); 
        float vertical = Input.GetAxis("Vertical"); 

        Vector3 direction = new Vector3(horizontal, 0, vertical).normalized; 

        if (direction.magnitude >= 0.1f)
        {
            controller.Move(direction * speed * Time.deltaTime); 
        }
    }
}
