using System.Collections.Generic;
using UnityEngine;

public class MonsterGenerator : MonoBehaviour
{
    [SerializeField] private Vector2 sizeArea = new Vector2(-250,250);
    [SerializeField] private int satrtAmountMonstersOnArea = 5;
    [SerializeField] private float timeCreateMonster = 5;
    [SerializeField] private int maxAmountMonsterInArea = 10;
    [SerializeField] private float minDistanceToMonsterGenerate = 50;
    [SerializeField] private MonsterNames[] monstersType;

    [HideInInspector] public List<Monster> monstersOnArea = new List<Monster>();

    private void Start()
    {
        for (int i = 0; i < satrtAmountMonstersOnArea; i++)
        {
            GenerateMonster(monstersType[Random.Range(0, monstersType.Length)]);
        }

        Invoke("CrateMonster", timeCreateMonster);
    }

    private void CrateMonster()
    {
        if (monstersOnArea.Count < maxAmountMonsterInArea)
        {
            GenerateMonster(monstersType[Random.Range(0, monstersType.Length)]);
        }
        Invoke("CrateMonster", timeCreateMonster);
    }


    private void GenerateMonster(MonsterNames monster)
    {
        GameObject objectGame = PoolController.Pop(monster.ToString());
        Monster newMonster = objectGame.GetComponent<Monster>();
        newMonster.Init();

        Vector2 randomPosition = GetRandomPosition();
        Vector3 newPosition = new Vector3(randomPosition.x, newMonster.transform.position.y, randomPosition.y);

        newMonster.transform.position = newPosition;
        monstersOnArea.Add(newMonster);
    }


    private Vector2 GetRandomPosition()
    {
        while (true)
        {
            Vector2 newPosition = new Vector2(Random.Range(sizeArea.x, sizeArea.y), Random.Range(sizeArea.x, sizeArea.y));
            float distance = Vector2.Distance(GameManager.Instance.PlayerObject.transform.position, newPosition);

            if (distance > minDistanceToMonsterGenerate)
            {
                return newPosition;
            }
        }
    }
}
