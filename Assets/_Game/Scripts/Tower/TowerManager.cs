using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerManager : MonoBehaviour
{
    public static TowerManager instance;

    [SerializeField] List<GameObject> allTowers = new List<GameObject>();
    [SerializeField] List<GameObject> inActiveTowers = new List<GameObject>();
    [SerializeField] List<GameObject> activeTowers = new List<GameObject>();
    public int maxActiveTower = 4;
    public float lifeTime = 10f;

    public GameObject[] animators;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        inActiveTowers.AddRange(allTowers);
        foreach (var tower in allTowers)
        {
            tower.gameObject.SetActive(false);
        }
    }

    public void StartTowerAnimation(GameObject tower)
    {
        tower.GetComponentInChildren<Animator>().SetTrigger("isUpTower");
    }

    private IEnumerator LifeRoutine(GameObject tower)
    {
        yield return new WaitForSeconds(lifeTime);
        tower.GetComponentInChildren<Animator>().SetTrigger("isDownTower");
        yield return new WaitForSeconds(1f);
        DeactiveTower(tower);
    }

    void DeactiveTower(GameObject tower)
    {
        if (activeTowers.Contains(tower))
        {
            activeTowers.Remove(tower);
        }
        if (!inActiveTowers.Contains(tower))
        {
            inActiveTowers.Add(tower);
        }
        tower.SetActive(false);
    }

    public void OnOrbCollected()
    {
        if (activeTowers.Count >= maxActiveTower) return;

        int randomIndex = Random.Range(0, inActiveTowers.Count);
        GameObject selectedTower = inActiveTowers[randomIndex];

        inActiveTowers.RemoveAt(randomIndex);
        activeTowers.Add(selectedTower);

        selectedTower.gameObject.SetActive(true);
        StartTowerAnimation(selectedTower);
        StartCoroutine(LifeRoutine(selectedTower));
    }
}
