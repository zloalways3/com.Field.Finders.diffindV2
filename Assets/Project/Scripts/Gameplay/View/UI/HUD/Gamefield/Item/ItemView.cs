using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
[RequireComponent(typeof(Item))]
public class ItemView : ButtonListener
{
    [SerializeField] private ItemTypeRepository _typeRepository;
    [SerializeField] private ItemTypeViewRepository _typeViewRepository;
    [SerializeField] private ClickedItemsCounter _clickedItemsCounter;

    [SerializeField] [Min(0.01f)] private float _animationDuration = 0.25f;
    [SerializeField] private AnimationCurve _animationEase;
    [SerializeField] [Range(-1.25f, 1.25f)] private float _wrongSize = 0.5f;

    private Item _item;
    private Image _image;

    private PureAnimation _animation;

    private Vector3 _defaultScale;

    public Item Item => _item;

    private float HalfDuration => _animationDuration * 0.5f;

    protected override void HandleInitialized()
    {
        _item = _item != null ? _item : GetComponent<Item>();
        _image = _image != null ? _image : GetComponent<Image>();

        _defaultScale = transform.localScale;
        _animation = new PureAnimation(this);
    }

    public void Actualize()
    {
        if (_item == null || _image == null || _defaultScale == Vector3.zero || _animation == null)
        {
            HandleInitialized();
        }

        _item.Reset();

        _image.sprite = _typeViewRepository.GetSpriteByType(_item.Type);

        transform.localScale = _defaultScale;
    }

    protected override void Listen()
    {
        if (_clickedItemsCounter.Count == _typeRepository.TargetCount - 1)
        {
            _item.TryClick();
            return;
        }

        if (!_item.TryClick())
        {
            _animation.Play(HalfDuration, (progress) =>
            {
                transform.localScale = _defaultScale + (_defaultScale * _wrongSize * _animationEase.Evaluate(progress));
            },
            () =>
            {
                _animation.Play(HalfDuration, (progress) =>
                {
                    transform.localScale = _defaultScale + (_defaultScale * _wrongSize * _animationEase.Evaluate(1f - progress));
                });
            });

            return;
        }

        _animation.Play(_animationDuration, (progress) =>
        {
            transform.localScale = _defaultScale * _animationEase.Evaluate(1f - progress);
        });
    }
}