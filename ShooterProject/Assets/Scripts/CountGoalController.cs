using UnityEngine;
using UnityEngine.UI;

public class CountGoalController : MonoBehaviour
{
    private const int MAX_COUNT = 25;
    private const int MIN_COUNT = 1;

    public static int Count = MIN_COUNT;

    [SerializeField] private Text _countText;

    public void AddGoal()
    {
        if (Count < MAX_COUNT)
            Count++;
        else
            Count = MIN_COUNT;
    }

    public void RemoveGoal()
    {
        if (Count > MIN_COUNT)
            Count--;
        else
            Count = MAX_COUNT;
    }

    private void Update() => _countText.text = Count.ToString();
}
