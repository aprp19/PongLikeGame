using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class PowerUpManager : MonoBehaviour
{
    public Transform spawnArea;
    public int maxPowerUpAmount;
    public Vector2 areaMin;
    public Vector2 areaMax;
    public int spawnInterval;
    private float _timer;
    
    public List<GameObject> powerTemplateList;
    public List<GameObject> powerUpList;
    
    void Start()
    {
        powerUpList = new List<GameObject>();
        _timer = 0;
    }

    private void Update()
    {
        _timer += Time.deltaTime;
        if (_timer > spawnInterval)
        {
            GenerateRandomPowerUp();
            _timer -= spawnInterval;
        }
    }

    public void GenerateRandomPowerUp()
    {
        GenerateRandomPowerUp(new Vector2(Random.Range(areaMin.x, areaMax.x), Random.Range(areaMin.y, areaMax.y)));
    }

    public void GenerateRandomPowerUp(Vector2 position)
    {
        if (powerUpList.Count >= maxPowerUpAmount)
        {
            return;
        }

        if (position.x < areaMin.x || position.x > areaMax.x || position.y < areaMin.y || position.y > areaMax.y)
        {
            return;
        }

        int randomIndex = Random.Range(0, powerTemplateList.Count);

        GameObject powerUp = Instantiate(powerTemplateList[randomIndex],
            new Vector3(position.x, position.y, powerTemplateList[randomIndex].transform.position.z),
            quaternion.identity, spawnArea);
        powerUp.SetActive(true);
        powerUpList.Add(powerUp);
    }

    public void RemovePowerUp(GameObject powerUp)
    {
        powerUpList.Remove(powerUp);
        Destroy(powerUp);
    }

    public void RemoveAllPowerUp()
    {
        while (powerUpList.Count > 0)
        {
            RemovePowerUp(powerUpList[0]);
        }
    }

    public void RemoveAfterTime(GameObject powerUp)
    {
        powerUpList.Remove(powerUp);
        Destroy(powerUp);
    }
}
