using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Keeps a 9-sliced plate from eating itself.
///
/// Unity's 9-slice holds the four border edges at a FIXED size and stretches only the
/// middle, so a plate whose border is wider than the rect it is drawn into renders as a
/// crooked sliver - and no gate catches it. The template plate here is
/// <c>sliced_solid_round</c>: 256x256 with a 127 px border on every side, i.e. 254 px of
/// border before any middle is left. A hand-picked <c>pixelsPerUnitMultiplier</c> of 1.4
/// means 181 px of border, which is fine on a 1060 px card and destroys a 96 px close
/// glyph, a 44 px bar or a 5 px rule.
///
/// So the multiplier is never a literal: it is derived from the sprite's own border and
/// the rect the plate actually got. The caller's value is the FLOOR (how round it wants
/// big plates to be) and a plate only ever gets sharper than that, never broken. It is
/// recomputed when the rect changes, which also covers autorotation (C.22).
/// </summary>
public sealed class _0x0ad0d1fe : MonoBehaviour
{
    private void LateUpdate()
    {
        this._0xa0579840();
    }

    public _0x0ad0d1fe _0xaa77dc98(Image _0x08b57e4a, float _0x9f1bd63f)
    {
        this._image = _0x08b57e4a;
        this._floor = Mathf.Max(0.05f, _0x9f1bd63f);
        this._0xa0579840();
        return this;
    }

    private void _0xa0579840()
    {
        if (this._image == null)
            return;
        RectTransform _0x08563a66 = this._image.rectTransform;
        if (_0x08563a66 == null)
            return;
        Vector2 _0x1953c94e = _0x08563a66.rect.size;
        if (_0x1953c94e.x <= 0f || _0x1953c94e.y <= 0f)
            return;
        if (Mathf.Abs(_0x1953c94e.x - this._0xc26497f5.x) < 0.5f && Mathf.Abs(_0x1953c94e.y - this._0xc26497f5.y) < 0.5f)
            return;
        this._0xc26497f5 = _0x1953c94e;
        float _0xfe19ae8e = this._floor;
        Sprite _0x12670c82 = this._image.sprite;
        if (_0x12670c82 != null)
        {
            Vector4 _0xe4f92719 = _0x12670c82.border;
            float _0x354db9ea = Mathf.Max(Mathf.Max(_0xe4f92719.x, _0xe4f92719.y), Mathf.Max(_0xe4f92719.z, _0xe4f92719.w));
            if (_0x354db9ea > 0f)
            {
                float _0x5215050c = _0x12670c82.pixelsPerUnit > 0f ? _0x12670c82.pixelsPerUnit : 100f;
                Canvas _0x91fbe8ff = this._image.canvas;
                float _0xaef14541 = _0x91fbe8ff != null ? _0x91fbe8ff.referencePixelsPerUnit : 100f;
                float _0x620d33c1 = Mathf.Max(1f, Mathf.Min(_0x1953c94e.x, _0x1953c94e.y));
                float _0xf6c84eb2 = 2f * _0x354db9ea * _0xaef14541 / (_0x5215050c * (1f - MiddleShare) * _0x620d33c1);
                if (_0xf6c84eb2 > _0xfe19ae8e)
                    _0xfe19ae8e = _0xf6c84eb2;
            }
        }

        this._image.pixelsPerUnitMultiplier = Mathf.Max(0.05f, _0xfe19ae8e);
    }

    private void OnEnable()
    {
        this._0xc26497f5 = new Vector2(-1f, -1f);
    }

    /// <summary>How much of the shortest side must stay as stretchable middle.</summary>
    private const float MiddleShare = 0.4f;
    private Vector2 _0xc26497f5 = new Vector2(-1f, -1f);
    [SerializeField]
    private float _floor = 1f;
    [SerializeField]
    private Image _image;
}