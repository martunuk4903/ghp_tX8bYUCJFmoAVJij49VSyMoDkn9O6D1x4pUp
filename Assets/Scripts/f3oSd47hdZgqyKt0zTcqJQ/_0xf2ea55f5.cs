using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A fixed ring of trail rows, built once at the start of a run and recycled from the bottom
/// of the screen back to the top. No Instantiate and no Destroy happens while the climb is
/// running.
/// Every sprite it makes is Sliced with an explicit size derived from the camera and a
/// sorting order from the named constants in TrailConfig, i.e. inside the -19..-1 corridor.
/// </summary>
public sealed class _0xf2ea55f5 : MonoBehaviour
{
    public IList<_0xc41019e2> _0xe83bdefc => this._0x58a82c67;

    private readonly List<_0xc41019e2> _0x58a82c67 = new List<_0xc41019e2>();
    private SpriteRenderer _0xd993c6aa(SpriteRenderer _0x295d5e73, Transform _0x550f622e, Vector3 _0x47bb36f8, float _0x00390e4e, int _0x9b32a6bb, bool _0x71e15fb5)
    {
        if (_0x295d5e73 == null)
            return null;
        SpriteRenderer _0x159d5816 = Instantiate(_0x295d5e73, _0x550f622e);
        _0x159d5816.transform.localPosition = _0x47bb36f8;
        _0x159d5816.transform.localScale = Vector3.one;
        _0x159d5816.size = new Vector2(_0x00390e4e, _0x00390e4e);
        _0x159d5816.sortingOrder = _0x9b32a6bb;
        _0x159d5816.gameObject.SetActive(_0x71e15fb5);
        return _0x159d5816;
    }

    public void _0xd6197845(Transform _0x8ff53d51, int _0x86249d73, float[] _0x531275c8, float _0x554cda3c, SpriteRenderer _0xdc7f277a, SpriteRenderer _0x66b9c56a, SpriteRenderer _0x97dd0c7e, SpriteRenderer _0xe19843e8)
    {
        this._0x062c8d1b = _0x8ff53d51;
        float _0xc0f601a8 = _0x554cda3c * 0.92f;
        float _0x605b3c5a = _0x554cda3c * 0.35f;
        float _0x83e05f5b = _0x554cda3c * 0.42f;
        float _0xd4ba780e = _0x554cda3c * 0.75f;
        for (int _0x2c76f931 = 0; _0x2c76f931 < _0x86249d73; _0x2c76f931++)
        {
            GameObject _0x6f2a153a = new GameObject(_0x94fe38de._0x541622ba(new byte[8] { 18, 20, 7, 15, 10, 52, 9, 17 }, 102));
            _0x6f2a153a.transform.SetParent(this._0x062c8d1b, false);
            _0xc41019e2 _0x699af6c7 = _0x6f2a153a.AddComponent<_0xc41019e2>();
            for (int _0x5e26f9b7 = 0; _0x5e26f9b7 < _0x5681a043.LaneCount; _0x5e26f9b7++)
            {
                Vector3 _0x9220f849 = new Vector3(_0x531275c8[_0x5e26f9b7], 0f, 0f);
                SpriteRenderer _0xa54f6442 = this._0xd993c6aa(_0xdc7f277a, _0x6f2a153a.transform, _0x9220f849, _0xc0f601a8, _0x5681a043.OrderTile, true);
                SpriteRenderer _0xabd79076 = this._0xd993c6aa(_0x66b9c56a, _0x6f2a153a.transform, _0x9220f849, _0x605b3c5a, _0x5681a043.OrderCoin, false);
                SpriteRenderer _0xa9bc16b6 = this._0xd993c6aa(_0x97dd0c7e, _0x6f2a153a.transform, _0x9220f849, _0x83e05f5b, _0x5681a043.OrderCore, false);
                SpriteRenderer _0xd5b8ec57 = this._0xd993c6aa(_0xe19843e8, _0x6f2a153a.transform, _0x9220f849, _0xd4ba780e, _0x5681a043.OrderPlume, false);
                _0x699af6c7._0xe8827b98(_0x5e26f9b7, _0xa54f6442, _0xabd79076, _0xa9bc16b6, _0xd5b8ec57);
            }

            this._0x58a82c67.Add(_0x699af6c7);
        }
    }

    private Transform _0x062c8d1b;
}

internal static class _0x94fe38de
{
    internal static string _0x541622ba(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}