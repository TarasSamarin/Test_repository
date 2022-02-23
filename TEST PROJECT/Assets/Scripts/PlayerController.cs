using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Target, IHitable
{
    [SerializeField] private float speedMove = 15f;
    [SerializeField] private float speedRotate = 85f;
    [SerializeField] [Range(0,1)] private float defence = 0.5f;
    [SerializeField] private float hitPoints = 1000;
    private WeaponSelector weaponSelector;

    private float currentHitPoints;
    private InputController inputManager;
    public void Hit(object sender, DamageEventArgs damageArgs)
    {
        OnDamage(sender, damageArgs);
    }

    private void Start()
    {
        weaponSelector = GetComponent<WeaponSelector>();
        weaponSelector.Init();

        inputManager = new InputController();

        inputManager.PlayerControll.Atack.performed += (context) => { Fire(); };
        inputManager.PlayerControll.ChangeWeaponNext.performed += (context) => { weaponSelector.ChangeNextWeapon(); };
        inputManager.PlayerControll.ChangeWeaponPrevious.performed += (context) => { weaponSelector.ChangePreviousWeapon(); };
        inputManager.Enable();

        currentHitPoints = hitPoints;
    }

    private void Update()
    {
        Vector2 inputAxis = inputManager.PlayerControll.Move.ReadValue<Vector2>();
        Move(inputAxis);
        Rotate(inputAxis);
    }

    private void Move(Vector2 inputAxis)
    {
        transform.Translate(new Vector3(0, 0, inputAxis.y * speedMove * Time.deltaTime));
    }

    private void Rotate(Vector2 inputAxis)
    {
        transform.Rotate(new Vector3(0, inputAxis.x * speedRotate * Time.deltaTime, 0));
    }

    private void Fire() 
    {
        weaponSelector.CurrentWeapon.Fire(this);
    }
    
    private void OnDamage(object sender, DamageEventArgs damageArgs)
    {
        currentHitPoints -= damageArgs.Damage * (1 - defence);
        float viewDamag = Mathf.InverseLerp(0, hitPoints, currentHitPoints);
        GameManager.Instance.ManagerUI.SetHitPointsProgress(viewDamag);

        if (currentHitPoints <= 0)
        {
            inputManager.Disable();
            GameManager.Instance.ManagerUI.ShowTextGameOver();
        }
    }


}
