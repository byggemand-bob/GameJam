using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawner : MonoBehaviour {

    public GameObject bullet;

    // Start is called before the first frame update
    void Start() {
        

    }

    // Update is called once per frame
    void FixedUpdate() {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = new Vector2(
            mousePosition.x - transform.position.x,
            mousePosition.y - transform.position.y
        );

        transform.up = direction;
        if(Input.GetMouseButtonUp(0)) {
            GameObject projectile = Instantiate(bullet, this.transform.position, transform.rotation);
        }
    }
}
