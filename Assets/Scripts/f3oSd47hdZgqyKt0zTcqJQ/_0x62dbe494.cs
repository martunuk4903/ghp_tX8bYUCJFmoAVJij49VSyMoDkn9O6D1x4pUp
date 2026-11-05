/// <summary>
/// Six rows of three lanes. cells[row * LaneCount + lane] holds one of the
/// TrailConfig.Cell* values. Built with Init(), never a constructor (C.59).
/// </summary>
public sealed class _0x62dbe494
{
    private int[] _0xe55d4a32 = new int[_0x5681a043.RowsPerSegment * _0x5681a043.LaneCount];
    public int _0x5978a06a(int _0x1a7cf5da)
    {
        int _0x6bf589c2 = 0;
        for (int _0x4f45b953 = 0; _0x4f45b953 < this._0xe55d4a32.Length; _0x4f45b953++)
            if (this._0xe55d4a32[_0x4f45b953] == _0x1a7cf5da)
                _0x6bf589c2++;
        return _0x6bf589c2;
    }

    public void _0x965d08ad(_0x62dbe494 _0xb692ccc5)
    {
        for (int _0xffa350c6 = 0; _0xffa350c6 < this._0xe55d4a32.Length; _0xffa350c6++)
            this._0xe55d4a32[_0xffa350c6] = _0xb692ccc5._0xe55d4a32[_0xffa350c6];
    }

    public int _0x251f1415(int _0x004b339c, int _0x6faafb64)
    {
        return this._0xe55d4a32[_0x004b339c * _0x5681a043.LaneCount + _0x6faafb64];
    }

    public void _0xf1267c8b()
    {
        for (int _0x7497dcb8 = 0; _0x7497dcb8 < this._0xe55d4a32.Length; _0x7497dcb8++)
            this._0xe55d4a32[_0x7497dcb8] = _0x5681a043.CellEmpty;
    }

    public void _0x4ed25bf7(int _0xba179aa5, int _0x9600271d, int _0x57b9bb20)
    {
        this._0xe55d4a32[_0xba179aa5 * _0x5681a043.LaneCount + _0x9600271d] = _0x57b9bb20;
    }

    public _0x62dbe494 _0x9e993001()
    {
        this._0xf1267c8b();
        return this;
    }
}