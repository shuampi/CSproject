
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
    public virtual void CalculatePay()
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

class Manager : Staff
{
    private const float managerHourlyRate = 50;

    public int Allowance { get; private set; }

    public Manager (string name) : base (name, managerHourlyRate)
    {}

    public override void CalculatePay()
    {
        base.CalculatePay();
        Allowance = 1000;
        if(HoursWorked > 160)
        {
            TotalPay = BasicPay + 1000;
        }
    }
    public override string ToString()
    {
        return $" manager hourly rate = {managerHourlyRate}, allowance = {Allowance} ";
    }
   
}

class Admin : Staff
{
    private const float overtimeRate = 15.5F;
    private const float adminHourlyRate = 30F;

    public float Overtime { get; private set; }

    public Admin(string name) : base(name, adminHourlyRate)
    {}

    public override void CalculatePay()
    {
        base.CalculatePay();
        if (HoursWorked > 160)
        {
            Overtime = overtimeRate * (HoursWorked - 160);
            TotalPay = BasicPay + Overtime;
        }
    }
}
