namespace ObjectOrientedProgramming_Exercise.Interfaces
{
    interface IDataBaseOperations<T>
    {
        void AddToDataBase(T vehicle, string databaseTxtPath);
    }
}
