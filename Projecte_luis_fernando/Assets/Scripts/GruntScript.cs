using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GruntScript : MonoBehaviour
{
    public Transform John;
    public GameObject BulletPrefab;
    public Rigidbody2D rbEnemigo;
    public float movespeed = 0;

    private int Health = 3;
    private float LastShoot;
    private Vector2 movement;

void Start(){
    rbEnemigo = this.GetComponent<Rigidbody2D>();
}
    void Update()
    {
        if (John == null) return;

        Vector3 direction = John.position - transform.position;
        Vector3 direction2 = John.position - transform.position;

        if (direction.x >= 0.0f) transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        else transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);

        float distance = Mathf.Abs(John.position.x - transform.position.x);

        if (distance < 1.0f && Time.time > LastShoot + 0.50)
        {
            rbEnemigo.AddForce(John.transform.position - transform.position);

            Shoot();
            LastShoot = Time.time;
        }
        direction2.Normalize();
        movement = direction2;

    }
    private void FixedUpdate(){
        moveGrunt(movement);
    }
    void moveGrunt(Vector2 direction2){
        rbEnemigo.MovePosition((Vector2)transform.position + (direction2 *Time.deltaTime));
    }

    private void Shoot()
    {
        Vector3 direction = new Vector3(transform.localScale.x, 0.0f, 0.0f);
        GameObject bullet = Instantiate(BulletPrefab, transform.position + direction * 0.10f, Quaternion.identity);
        bullet.GetComponent<BulletScript>().SetDirection(direction);
    }

    public void Hit()
    {
        Health -= 1;
        if (Health == 0){ 
        ScoreScripts.scoreValue +=1;
         Destroy(gameObject); 
        }
    }
}