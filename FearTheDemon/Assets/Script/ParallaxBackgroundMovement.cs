using UnityEngine;

public class ParallaxBackgroundMovement : MonoBehaviour
{
    [SerializeField]
    private Transform mainCameraPosition;

    [SerializeField]
    private float backgroundMoveSpeed;
    private float directionX;

    [SerializeField]
    private float offsetByX = 13f;

    void Start()
    {
        if (GameObject.FindWithTag("Player"))
            mainCameraPosition = GameObject.FindWithTag("Player").transform;
    }
    void Update()
    {
        directionX = Input.GetAxis("Horizontal") * backgroundMoveSpeed * Time.deltaTime;

        transform.position = new Vector2(transform.position.x + directionX, transform.position.y);

        if (transform.position.x - mainCameraPosition.position.x < -offsetByX)
        {
            transform.position = new Vector2(mainCameraPosition.position.x + offsetByX,
                transform.position.y);
        }
        else if (transform.position.x - mainCameraPosition.position.x > offsetByX)
            transform.position = new Vector2(mainCameraPosition.position.x - offsetByX, transform.position.y);
        {

        }
    }
}
