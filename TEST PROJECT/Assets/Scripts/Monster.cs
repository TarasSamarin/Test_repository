using System.Collections;
using UnityEngine;

public class Monster : MonoBehaviour, IHitable
{
    public MonsterNames MonsterName;
    public MonsterHPView View;

    [SerializeField] private float hitPoints = 500;
    [SerializeField] private float damage = 100;
    [SerializeField] private float speed = 5;
    [SerializeField] private float delayAfterAtack = 5;
    [SerializeField] [Range(0, 1)] private float defence = 0.5f;

    private ITarget target;
    private bool isMove;
    private float currentHitPoints;
    
    public void Init()
    {
        isMove = true;
        target = GameManager.Instance.target;
        currentHitPoints = hitPoints;
        View.SetProgressBar(1);
    }

    public void Hit(object sender, DamageEventArgs damageArgs)
    {
        OnDamage(damageArgs.Damage);
    }

    private void Update()
    {
        if (isMove && target != null)
        {
            transform.LookAt(new Vector3(
                target.GetPosition().x,
                transform.position.y,
                target.GetPosition().z));

            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
    }

    private void OnDamage(float damage)
    {
        currentHitPoints -= damage * (1 - defence);
        float viewDamag = Mathf.InverseLerp(0, hitPoints, currentHitPoints);
        View.SetProgressBar(viewDamag);

        if (currentHitPoints <= 0)
        {
            GameManager.Instance.GeneratorMonster.monstersOnArea.Remove(this);
            PoolController.Push(MonsterName.ToString(), gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetInstanceID() == target.GetInstanceID() && isMove == true) 
        {
            collision.gameObject.GetComponent<IHitable>().Hit(this,new DamageEventArgs(damage));
            StartCoroutine(MoveDelay(delayAfterAtack));
        }
    }

    private IEnumerator MoveDelay(float time)
    {
        isMove = false;
        yield return new WaitForSeconds(time);
        isMove = true;
    }
}
