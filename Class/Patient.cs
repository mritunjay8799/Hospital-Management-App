namespace Hospital_Management_App.Class
{
    public class Patient
    {
        private readonly string? name;
        private readonly int age;
        private readonly string? bloodtype;
        private readonly List<string?> medicalHistory;

        public Patient(string _name, int _age, string _bloodType)
        {
            name = _name;
            age = _age;
            bloodtype = _bloodType;
            medicalHistory = new List<string?>();
        }

        public string Name => name!;
        public int Age => age;
        public string BloodType => bloodtype!;
        public IReadOnlyList<string?> MedicalHistory => medicalHistory.AsReadOnly();


        public void AddDiagnosis(string _diagnosis)
        {
            if (string.IsNullOrEmpty(_diagnosis)) throw new ArgumentException("Diagnosis is not correct.");

            medicalHistory.Add(_diagnosis);
        }

        public void Summary()
        {
            Console.WriteLine("---------Pateint Summary-------");
            Console.WriteLine($"Name              :    {Name}");
            Console.WriteLine($"Age               :    {Age}");
            Console.WriteLine($"BloodType         :    {BloodType}");
            Console.WriteLine($"Medical History");

            if (medicalHistory.Count == 0)
            {
                Console.WriteLine("No Medical History");
            }
            else
            {
                foreach (string rec in medicalHistory)
                {
                    Console.WriteLine($"=> {rec}");
                }
            }
            Console.WriteLine("------------------------------");
        }
    }
}
