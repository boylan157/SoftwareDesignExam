using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignExam
{
    public interface ICar
    {
        double GetPrice();
        string GetDescription();

        string GetBrand();

        string GetModel();

        string GetColor();

        int GetYear();
        bool GetAutomatic();
    }
}
