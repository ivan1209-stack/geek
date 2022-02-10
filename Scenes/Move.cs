using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Walkyrie_SwitchEngine_01 Walkyrie_SwitchEngine;
    private Vector3 direction;
    private Rigidbody rb;
    private float x = 0;
    private float y = 0;

    public float speed;
    public float speedrotation;
    public float speedmaneuver;
    private float z = 0;
    [HideInInspector]public Quaternion rotater;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        TryGetComponent<Walkyrie_SwitchEngine_01>(out Walkyrie_SwitchEngine);
        TryGetComponent<Rigidbody>(out rb);
    }

    // Update is called once per frame
    void Update()
    {
        SpeedOfMoving();
        z = 0;
        if (Input.GetKey(KeyCode.D))
        {
            z = 2 * speedmaneuver;
        }
        if (Input.GetKey(KeyCode.A))
        {
            z = -2 * speedmaneuver;
        }
        x = Input.GetAxis("Mouse Y") * speedrotation;
        y = Input.GetAxis("Mouse X") * speedrotation;
        Quaternion axisX = Quaternion.AngleAxis(y, Vector3.up);
        Quaternion axisY = Quaternion.AngleAxis(x, Vector3.right);
        Quaternion axisZ = Quaternion.AngleAxis(z, Vector3.forward);
        transform.Rotate(new Vector3(x, y, z));
        rotater = transform.rotation;
        //rotater.y = rotater.y - 180f;
    }
    void FixedUpdate()
    {
        
        direction = Vector3.forward * speed * Time.fixedDeltaTime;
        direction = transform.TransformDirection(direction);
        rb.AddForce(direction);
    }
    private void SpeedOfMoving()
    {
        if (Input.GetKey(KeyCode.F))
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 270, 0));
        }
        if (speed > -500f && Input.GetKey(KeyCode.W))
        {
            speed -= 1f;
        }
        if (speed < 500f && Input.GetKey(KeyCode.S))
        {
            speed += 1f;
        }
        if (Input.GetKey(KeyCode.R))
        {
            speed = 0;
        }
    }
    private IEnumerator Timer(float time) {
        yield return new WaitForSeconds(time);
    }
}
