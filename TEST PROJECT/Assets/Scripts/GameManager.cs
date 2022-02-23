using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public PlayerController PlayerObject;
    public UIManager ManagerUI;
    public MonsterGenerator GeneratorMonster;
    [HideInInspector] public Target target;

    private void Awake()
    {
        Instance = this;
        target = FindObjectOfType<Target>();
    }
}
