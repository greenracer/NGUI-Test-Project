using System.Collections.Generic;
using UnityEngine;

public class CellGenerator : MonoBehaviour
{
    [SerializeField] private GameObject _cellPrefab;
    private UIGrid _grid;

    private string _pageType => gameObject.name;
    private static List<PlayerData> _players;

    private void Awake()
    {
        _players = PlayerDatabase.GetData();
        _grid = GetComponent<UIGrid>();
    }

    private void Start()
    {
        switch(_pageType)
        {
            case "Today Page":
                _players.Sort((x, y) => y.ExpForToday.CompareTo(x.ExpForToday));
                break;
            case "Week Page":
                _players.Sort((x, y) => y.ExpForWeek.CompareTo(x.ExpForWeek));
                break;
            case "Month Page":
                _players.Sort((x, y) => y.ExpForMonth.CompareTo(x.ExpForMonth));
                break;
            case "Overall Page":
                _players.Sort((x, y) => y.ExpOverall.CompareTo(x.ExpOverall));
                break;
        }
        for (int i = 0; i < _players.Count; i++)
        {
            Cell cell = Instantiate(_cellPrefab, _grid.transform).GetComponent<Cell>();
            _grid.AddChild(cell.transform);
            _grid.ConstrainWithinPanel();
            _grid.repositionNow = true;
            _players[i].RatingPlace = i + 1;
            cell.SetData(_players[i]);
        }
    }
}
