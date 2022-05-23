using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Complete
{
    public class Mines : MonoBehaviour
    {
        float damage = 10;
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Player")
            {
                TankHealth health = collision.gameObject.GetComponent<TankHealth>();
                health.TakeDamage(damage);
                Destroy(gameObject);
            }
        }
    }
}
