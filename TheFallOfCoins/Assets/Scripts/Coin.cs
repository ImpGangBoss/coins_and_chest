using UnityEngine;

public class Coin : MonoBehaviour
{
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Chest")
        {
            gameObject.SetActive(false);
            _rigidbody.velocity = Vector3.zero;
        }    
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Bounds")
        {
            gameObject.SetActive(false);
            _rigidbody.velocity = Vector3.zero;
        }
    }
}
