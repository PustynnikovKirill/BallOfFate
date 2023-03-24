using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody _rb;

    public Text scoreText;
    private int _score = 0;

    private void Awake()  
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        // Vector3 acceleration = Input.acceleration;
        // GetComponent<Rigidbody>().velocity = new Vector3(acceleration.x, acceleration.z, 0);

        // Vector3 dir = Vector3.zero;
        // dir.x = -Input.acceleration.y;
        // dir.z = Input.acceleration.x;
        // if (dir.sqrMagnitude > 1)
        //    dir.Normalize();
        // dir *= Time.deltaTime;
        // transform.Translate(dir * speed);

         float h = Input.GetAxis("Horizontal") * speed * Time.fixedDeltaTime;
         float v = Input.GetAxis("Vertical") * speed * Time.fixedDeltaTime;

         _rb.velocity = transform.TransformDirection(new Vector3(v, _rb.velocity.y, -h));
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Respawn")
        {
            _score++;
            Destroy(other.gameObject);

            if(_score != 5)
            scoreText.text = "Score: " + _score;
            else
            scoreText.text = "You win!";
        }
    }
}
