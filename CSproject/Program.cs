
class Staff
{   //fields
    private float hourlyRate;
    private int hWorked;

    // auto-implemented properties
    public float TotalPay { get;protected set; }
    public float BasicPay { get;private set; }
    public string? NameOfStaff { get; private set; }
    public int HoursWorked
    { 
    get
        {
            return hWorked;
        }
    set
        {
            if(value > 0)
            {
                hWorked = value;
            } else
            {
                hWorked = 0;
            }
        }
    
    }
    //constructor
    public Staff (string name, float rate)
    {
        NameOfStaff = name;
        hourlyRate = rate;
    }

    //methods
    public void CalculatePay()
    {
        Console.WriteLine("Calculating pay...");
        BasicPay = hWorked * hourlyRate;
        TotalPay = BasicPay;
    }
    public override string ToString()
    {
        return $"Name of staff = {NameOfStaff}, hourly rate = {hourlyRate}, hours worked = {hWorked}," +
            $" Basic pay = {BasicPay}, Total pay = {TotalPay}";
    }
}

