using UnityEngine;

public class Tab : MonoBehaviour
{
    [SerializeField] private GameObject _page;
    public UIButton Button { get; private set; }

    private void Awake()
    {
        Button = GetComponent<UIButton>();
    }

    public void SetActivePage(bool condition)
    {
        _page.SetActive(condition);
    }
}
