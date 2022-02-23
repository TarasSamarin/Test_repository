using System.Collections;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public BulletNames BulletName;
    public Sprite IconGun;

    [HideInInspector] public PlayerController owner;

    [SerializeField] private int damage = 100;
    [SerializeField] private float speed = 1f;
    [SerializeField] private float timeDestroy = 5f;

    private Rigidbody rigidBodyComponent;

    private void Start()
    {
        rigidBodyComponent = GetComponent<Rigidbody>();
    }

    public void Init()
    {
        StartCoroutine(DestroyBullet());
    }

    private void Reset()
    {
        rigidBodyComponent.velocity = Vector3.zero;
        rigidBodyComponent.angularVelocity = Vector3.zero;
    }

    private IEnumerator DestroyBullet()
    {
        yield return new WaitForSeconds(timeDestroy);
        Destroy();
    }

    private void Destroy()
    {
        PoolController.Push(BulletName.ToString(), gameObject);
        Reset();
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out IHitable hitable) && owner.gameObject.GetInstanceID() != collision.gameObject.GetInstanceID())
        {
            hitable.Hit(this,new DamageEventArgs(damage));
            Destroy();
        }
    }
}
