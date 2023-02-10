using System;
namespace FactoryPatternExercise2
{
    public interface IDataAccess
    {
        
        List<Product> LoadData();
        void SaveData();
    }



}