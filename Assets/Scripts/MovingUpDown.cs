using UnityEngine;

public class MovingUpDown : MonoBehaviour
{
    [SerializeField] private float movementDistance;
    [SerializeField] private float speed;
    [SerializeField] private float damage;
    private bool movingUp;
    private float topEdge;
    private float bottomEdge;

    //At Load, set y boundaries for saw
    private void Awake()
    {
        topEdge = transform.position.y + movementDistance;
        bottomEdge = transform.position.y - movementDistance;
    }

    //Moving Saw up and down
    private void Update()
    {
        if (movingUp)
        {
            if (transform.position.y < topEdge)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + speed * Time.deltaTime, transform.position.z);
            }
            else
                movingUp = false;
        }
        else
        {
            if (transform.position.y > bottomEdge)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - speed * Time.deltaTime, transform.position.z);
            }
            else
                movingUp = true;
        }
    }

}