using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    private const int HIGHSCORETABLESIZE = 3;
    public GameObject playerPrefab;
    public int demoNumber = 13;
    public List<PlayerSpawnPoint> playerSpawnPoints;
    public List<ScoreData> scores = new List<ScoreData>();

    protected override void Awake()
    {
        base.Awake();
        playerSpawnPoints = new List<PlayerSpawnPoint>();
        scores.Sort();
        scores.Reverse();
        // Limit the size of the high score table
        scores = scores.GetRange(index: 0, count: HIGHSCORETABLESIZE);
    }

    public void SpawnPlayer()
    {
        // TODO: Write code to spawn the player at a random spawn point.
    }
}
