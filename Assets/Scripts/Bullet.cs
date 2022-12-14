using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Transform target;
    public float speed = 30f;
    public GameObject impactEffect;

    public void Seek(Transform _target)
    {
        target = _target;
    }
    void Update()
    {
        if(target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;
        if (dir.magnitude <= distanceThisFrame)
        {
            Hit();
            return;
        }

        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
    }
    void Hit()
    {
        GameObject effectInstance = Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(effectInstance, 2f);
        Destroy(gameObject);
        Destroy(target.gameObject);
    }
}
