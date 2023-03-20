
class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase() 
    {
        this.storedData = new List<T>();
        this.inputDates = new List<DateTime>();
    }

    public void addNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void printAllData()
    {
        for(int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine("Data " + (i+1) + "Berisi: " + storedData[i] + "Yang Disimpan pada waktu UTC: " + inputDates[i]);
        }
    }
}

class MainProgram
{
    static void Main(string[] args)
    {
        SimpleDataBase<double> data = new SimpleDataBase<double>();

        data.addNewData(13);
        data.addNewData(02);
        data.addNewData(21);
        data.printAllData(); 
    }
}

