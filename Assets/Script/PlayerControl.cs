using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    public float speed = 5f;
    
    private Rigidbody _rb;

    public Text scoreText;
    private int _score = 0;
    private int _scoreEnd = 0;

    private string text = "Score: ";

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }
    private void Start ()
    {
        GameObject.Find("Time").GetComponent<Timer>().timeStart = 30;
    }

    private void FixedUpdate()
    {
        //1. Vector3 acceleration = Input.acceleration;
        // GetComponent<Rigidbody>().velocity = new Vector3(acceleration.x, acceleration.z, 0);

        //2. Vector3 dir = Vector3.zero;
        // dir.x = -Input.acceleration.y;
        // dir.z = Input.acceleration.x;
        // if (dir.sqrMagnitude > 1)
        //    dir.Normalize();
        // dir *= Time.deltaTime;
        // transform.Translate(dir * speed);

        float h = Input.GetAxis("Horizontal") * speed * Time.fixedDeltaTime;
        float v = Input.GetAxis("Vertical") * speed * Time.fixedDeltaTime;

        _rb.velocity = transform.TransformDirection(new Vector3(v, _rb.velocity.y, -h));

        if (GameObject.Find("Time").GetComponent<Timer>().timeStart == 0)
            scoreText.text = "You lose!";

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Respawn")
        {
            _score++;
            Destroy(other.gameObject);

            if (_score != 8 && _scoreEnd < 2)
                scoreText.text = text + _score;
            else
                scoreText.text = "You lose!";
        }
        if (other.gameObject.tag == "EditorOnly")
        {
            _score--;
            _scoreEnd++;
            Destroy(other.gameObject);

            if (_scoreEnd < 2)
                scoreText.text = text + _score;
            else
                scoreText.text = "You lose!";
        }

        if (other.gameObject.tag == "Finish")
        { 
            if (_score >= 6)
                scoreText.text = "You win!";
            else
                scoreText.text = "You lose!";
        }
       
    }
}
