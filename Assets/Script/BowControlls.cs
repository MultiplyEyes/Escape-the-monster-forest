using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BowControlls : MonoBehaviour
{
    public GameObject arrow;
    public float arrowSpeed = 20;
    public float adjustAngle = 0;

    public float shootDelay = 1f;
    private float shootTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = -(transform.position.x - Camera.main.transform.position.x);

        Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);

        Vector3 direction = worldPos - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle - adjustAngle, Vector3.forward);

        

        if (Input.GetMouseButtonDown(0) && Time.time > shootTime)
        {
            Shoot();
            shootTime = Time.time + shootDelay;
        }

        // float mousePosX = Input.mousePosition.x;

        // if (mousePosX < (Screen.width / 2) + 1)
        // {
        //     transform.localPosition = new Vector3(-1.2f, 0, 0);
        // }
        // else if(mousePosX > (Screen.width / 2) + 1)
        // {
        //     transform.localPosition = new Vector3(1.2f, 0, 0);
        // }
    }

    void Shoot()
    {
        GameObject newArrow = Instantiate(arrow, transform.position, transform.rotation);
        newArrow.GetComponent<Rigidbody2D>().velocity = transform.right * arrowSpeed;
        Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Layer 2"), LayerMask.NameToLayer("Layer 1"));
    }
}
