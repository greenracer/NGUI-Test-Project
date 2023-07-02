using UnityEngine;

public class Cell : MonoBehaviour
{
    [SerializeField] private UILabel _playerIdLabel;
    [SerializeField] private UILabel _placeLabel;
    [SerializeField] private UILabel _expLabel;
    [SerializeField] private UILabel _avatarLabel;
    [SerializeField] private UISprite _sprite;
    public void SetData(PlayerData data)
    {
        _playerIdLabel.text = data.Id.ToString();
        _placeLabel.text = data.RatingPlace.ToString();
        _expLabel.text = $"{data.ExpOverall} EXP";
        _avatarLabel.text = $"{data.Avatar} AVATAR";
        _sprite.spriteName = data.Avatar.ToString();
    }
}
