using UnityEngine;

public class Coin : MonoBehaviour
{
    public float rotateSpeed = 100f;

    void Update()
    {
        
     
        transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.IncreaseScore(); 
            Destroy(gameObject); 
        }
    }
}
