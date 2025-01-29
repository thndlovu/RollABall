using UnityEngine;

public class BallController : MonoBehaviour {
    [SerializeField] private Rigidbody sphereRigidbody;
    [SerializeField] float ballSpeed;
 
    // Update is called once per frame
    public void MoveBall(Vector2 input){
        Vector3 inputXZPlane = new Vector3(input.x, 0, input.y);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);
    }
}
