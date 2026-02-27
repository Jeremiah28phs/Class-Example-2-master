using UnityEngine;
//If the player presses the spacebar, we willl add 10 to a points
//If the player presses w, have them spin around in place
// Every 10 seconds, give the player 1xp pooint
// After 5 xp points, increase the players level


public class LevelXP : MonoBehaviour
{
    public int points;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        points=0;
    }

    // Update is called once per frame
    void Update()
    {
    if (Input.GetKeyDown(KeyCode.Space))
        {
            points += 10;
        }
    }
}
