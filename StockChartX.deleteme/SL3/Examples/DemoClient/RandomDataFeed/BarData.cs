﻿using System;

namespace ModulusFE.OMS.Interface
{
  public partial class BarData
  {
    private string _symbol;
    private DateTime _tradeDate;
    private double _openPrice;
    private double _highPrice;
    private double _lowPrice;
    private double _closePrice;
    private double _volume;

    partial void SymbolChanged();
    partial void DateTimeChaged();
    partial void OpenPriceChanged();
    partial void HighPriceChanged();
    partial void LowPriceChanged();
    partial void ClosePriceChanged();
    partial void VolumeChanged();

    public string Symbol
    {
      get { return _symbol; }
      set
      {
        if (_symbol == value) return;

        _symbol = value;
        SymbolChanged();
      }
    }

    public DateTime TradeDate
    {
      get { return _tradeDate; }
      set
      {
        if (_tradeDate == value) return;

        _tradeDate = value;
        DateTimeChaged();
      }
    }

    public double OpenPrice
    {
      get { return _openPrice; }
      set
      {
        if (_openPrice == value) return;

        _openPrice = value;
        OpenPriceChanged();
      }
    }

    public double HighPrice
    {
      get { return _highPrice; }
      set
      {
        if (_highPrice == value) return;

        _highPrice = value;
        HighPriceChanged();
      }
    }

    public double LowPrice
    {
      get { return _lowPrice; }
      set
      {
        if (_lowPrice == value) return;

        _lowPrice = value;
        LowPriceChanged();
      }
    }

    public double ClosePrice
    {
      get { return _closePrice; }
      set
      {
        if (_closePrice == value) return;

        _closePrice = value;
        ClosePriceChanged();
      }
    }

    public double Volume
    {
      get { return _volume; }
      set
      {
        if (_volume == value) return;

        _volume = value;
        VolumeChanged();
      }
    }

    public bool Equals(BarData other)
    {
      if (ReferenceEquals(null, other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return other._tradeDate.Equals(_tradeDate) && other._openPrice == _openPrice && other._highPrice == _highPrice &&
             other._lowPrice == _lowPrice && other._closePrice == _closePrice && other._volume == _volume;
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != typeof(BarData)) return false;
      return Equals((BarData)obj);
    }

    public override int GetHashCode()
    {
      unchecked
      {
        int result = _tradeDate.GetHashCode();
        result = (result * 397) ^ _openPrice.GetHashCode();
        result = (result * 397) ^ _highPrice.GetHashCode();
        result = (result * 397) ^ _lowPrice.GetHashCode();
        result = (result * 397) ^ _closePrice.GetHashCode();
        result = (result * 397) ^ _volume.GetHashCode();
        return result;
      }
    }
  }
}
