using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class _0x463ff4ef : MonoBehaviour
{
    private bool _0x59f1b15f(Touch? _0x928b4d38)
    {
        if (!_0x928b4d38.HasValue)
            return false;
        Vector3 _0x04a1cddd = Camera.main.ScreenToWorldPoint(_0x928b4d38.Value.screenPosition);
        Vector3 _0xc1fad0dd = _0x04a1cddd;
        _0xc1fad0dd.z = this.CameraTouchBounds.transform.position.z;
        if (this.CameraTouchBounds.bounds.Contains(_0xc1fad0dd))
            return true;
        _0x928b4d38 = null;
        return false;
    }

    private Touch? _0x91224962(Bounds _0x440bb1a1)
    {
        if (!_0xe6558cf1.Instance._0x04b70943)
            return null;
        foreach (Touch _0x130324e3 in Touch.activeTouches)
            if (!_0x130324e3.ended)
            {
                Vector3 _0x581aee0a = Camera.main.ScreenToWorldPoint(_0x130324e3.screenPosition);
                Vector3 _0x094b9621 = new(_0x581aee0a.x, _0x581aee0a.y, _0x440bb1a1.center.z);
                if (_0x440bb1a1.Contains(_0x094b9621) && this._0x59f1b15f(_0x130324e3))
                    return _0x130324e3;
            }

        return null;
    }

    private static _0x463ff4ef _0xc234a19b;
    public BoxCollider2D CameraTouchBounds;
    private Touch? _0xa668696d(Bounds _0xf63f6a8b)
    {
        if (!_0xe6558cf1.Instance._0x04b70943)
            return null;
        foreach (Touch _0x553432dc in Touch.activeTouches)
            if (_0x553432dc.ended)
            {
                Vector3 _0x1c1bb6a5 = Camera.main.ScreenToWorldPoint(_0x553432dc.screenPosition);
                Vector3 _0x856555d3 = new(_0x1c1bb6a5.x, _0x1c1bb6a5.y, _0xf63f6a8b.center.z);
                if (_0xf63f6a8b.Contains(_0x856555d3) && this._0x59f1b15f(_0x553432dc))
                    return _0x553432dc;
            }

        return null;
    }

    private Touch? _0x2e1df85f()
    {
        if (!_0xe6558cf1.Instance._0x04b70943)
            return null;
        foreach (Touch _0x22c8cad5 in Touch.activeTouches)
            if (!_0x22c8cad5.ended)
                if (this._0x59f1b15f(_0x22c8cad5))
                    return _0x22c8cad5;
        return null;
    }

    private Touch? _0xce5afb70(Bounds _0x3f6c0f14, TouchPhase _0x17594788)
    {
        if (!_0xe6558cf1.Instance._0x04b70943)
            return null;
        foreach (Touch _0x0af7223a in Touch.activeTouches)
            if (_0x0af7223a.phase == _0x17594788)
            {
                Vector3 _0x3568fdf2 = Camera.main.ScreenToWorldPoint(_0x0af7223a.screenPosition);
                Vector3 _0x226c74b3 = new(_0x3568fdf2.x, _0x3568fdf2.y, _0x3f6c0f14.center.z);
                if (_0x3f6c0f14.Contains(_0x226c74b3) && this._0x59f1b15f(_0x0af7223a))
                    return _0x0af7223a;
            }

        return null;
    }

    private void _0x7f8a9594(Touch? _0x4ac9e045)
    {
        if (!_0xe6558cf1.Instance._0x04b70943)
        {
            _0x4ac9e045 = null;
            return;
        }

        int _0x72b012c0 = _0x4ac9e045.Value.touchId;
        _0x4ac9e045 = Touch.activeTouches.FirstOrDefault(_0x5912f01a => _0x5912f01a.touchId == _0x72b012c0);
        if (!this._0x59f1b15f(_0x4ac9e045.Value))
            _0x4ac9e045 = null;
    }

    private Touch? _0x40901371()
    {
        if (!_0xe6558cf1.Instance._0x04b70943)
            return null;
        foreach (Touch _0x920e6190 in Touch.activeTouches)
            if (_0x920e6190.ended)
                if (this._0x59f1b15f(_0x920e6190))
                    return _0x920e6190;
        return null;
    }

    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        _0xc234a19b = this.gameObject.GetComponent<_0x463ff4ef>();
    }

    private bool _0x0910f831(Touch? _0x4fecf4bf, Bounds _0xe96625d0, TouchPhase _0xd05c6915)
    {
        if (!_0xe6558cf1.Instance._0x04b70943)
        {
            _0x4fecf4bf = null;
            return false;
        }

        if (_0x4fecf4bf != null)
            if (_0x4fecf4bf.Value.phase == _0xd05c6915)
            {
                Vector3 _0xb8e2c6e7 = Camera.main.ScreenToWorldPoint(_0x4fecf4bf.Value.screenPosition);
                Vector3 _0xfaf89e56 = new(_0xb8e2c6e7.x, _0xb8e2c6e7.y, _0xe96625d0.center.z);
                if (_0xe96625d0.Contains(_0xfaf89e56) && this._0x59f1b15f(_0x4fecf4bf.Value))
                    return true;
            }

        return false;
    }
}