using UnityEngine;

public class Obstacle : MonoBehaviour
{

    [SerializeField] float _moveSpeed = 2.5f;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x - _moveSpeed * Time.deltaTime, transform.position.y, transform.position.z);
    }
}
