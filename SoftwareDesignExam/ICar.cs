

namespace SoftwareDesignExam
{
    //interface for car
    public interface ICar
    {
        double GetPrice();

        string GetType();

        string GetBrand();

        string GetModel();

        string GetColor();

        int GetYear();

        bool GetAutomatic();
    }
}
