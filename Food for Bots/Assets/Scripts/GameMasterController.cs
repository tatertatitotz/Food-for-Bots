using UnityEngine;

public class GameMasterController : MonoBehaviour
{
    public int PlayerMax { get; private set; }
    public int PlayerMin { get; private set; }
    public void SetPlayerMax(int playerMax)
    {
        if (playerMax <= 4)
            PlayerMax = playerMax;
        else
            throw new System.Exception("Too Greedy >:[");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetPlayerMax(4);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
