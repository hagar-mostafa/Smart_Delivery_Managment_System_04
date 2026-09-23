using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_04
{
    #region Interfaces
    public interface ITrackable
    {
        string GetTrackingStatus();
    }

    public interface IInsurable
    {
        decimal CalculateInsurance();
    }
    #endregion
}
