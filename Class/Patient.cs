namespace Hospital_Management_App.Class
{
    public class Patient
    {
        private static readonly HashSet<string> ValidBloodTypes = new() { "A-", "A+", "B-", "B+","AB+","AB-","O-","O+" }; 

        private readonly string? name;
        private int age;
        private string bloodtype;
        private readonly List<string?> medicalHistory;
        private int balance;

        public Patient(string _name, string _bloodType)
        {
            name = _name;
            bloodtype = _bloodType;
            medicalHistory = new List<string?>();
        }

        public string Name => name!;
        public int Age
        {
            get => age;
            set
            {
                if (value < 0 || value > 150)
                    throw new InvalidDataException($"Age can't be {age}. It should be between 0 to 150");

                 age = value;
            }
        }
        public string BloodType
        {
            get => bloodtype!;
            set
            {
                if (!ValidBloodTypes.Contains(value))
                    throw new InvalidDataException($"{value} is not a valid blood type");

                bloodtype = value;
            }
        }
        public IReadOnlyList<string?> MedicalHistory => medicalHistory.AsReadOnly();
        public int Balance => balance;


        public void AddDiagnosis(string _diagnosis, int price)
        {
            if (string.IsNullOrEmpty(_diagnosis)) throw new InvalidDataException("Diagnosis is not correct.");

            if (price < 0)
            {
                throw new InvalidDataException("Price can not be negative");
            }

            medicalHistory.Add(_diagnosis);
            CheckOut(price);
        }

        public void Summary()
        {
            Console.WriteLine("=========Pateint Summary=======");
            Console.WriteLine($"Name              :    {Name}");
            Console.WriteLine($"Age               :    {Age}");
            Console.WriteLine($"BloodType         :    {BloodType}");
            Console.WriteLine($"Medical History   : ");

            if (medicalHistory.Count == 0)
            {
                Console.WriteLine("No Medical History");
            }
            else
            {
                foreach (var rec in medicalHistory)
                {
                    Console.WriteLine($"                     {rec}");
                }
            }
            Console.WriteLine($"Total Bill        : {Balance}");
            Console.WriteLine("------------------------------");
        }

        private void ApplyCharge(int amount)    // private setter for balance
        {
            if (amount < 0)
            {
                throw new InvalidDataException("Amount can not be less than 0.");
            }
            balance += amount;
        }

        public void CheckOut(int amount)
        {
            ApplyCharge(amount);
        }
    }
}
