using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Complete
{
    public class Cure : MonoBehaviour
    {
        float cure = 10;
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Player")
            {
                TankHealth health = collision.gameObject.GetComponent<TankHealth>();
                health.TakeDamage(-cure);
                if (health.m_CurrentHealth > 100) health.m_CurrentHealth = 100;
                Destroy(gameObject);
            }
        }
    }
}