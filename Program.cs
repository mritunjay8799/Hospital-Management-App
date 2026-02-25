using Hospital_Management_App.Class;

/*

1. Create a `Patient` class. Keep `name`, `age`, `bloodType`, `medicalHistory` private. Expose getters(read value) for each and add 
`addDiagnosis(entry)`. Print a formatted patient summary to the console.

2. Add validation in setters: age must be 0–150, bloodType from a fixed list. Throw descriptive errors on bad input. 
Test with invalid data and confirm errors are caught gracefully.

3. Add private `_balance`, a public getter, and a private `applyCharge(amount)`. Expose a `checkout()` method that calculates 
and prints the final bill. No external code touches the balance directly.

4.Add a static `Patient.generateReport(patientArray)` that prints a formatted table: ID | Name | Age | Diagnoses | Balance.
Run it in `main()` with 3 sample patients.

 */

try
{
    List<Patient> patients = new List<Patient>();
    Patient patient = new Patient(1,"Mahesh");
    patient.BloodType = "A-";
    patient.Age = 20;
    patient.AddDiagnosis("Malaria", 200);
    patient.AddDiagnosis("TuberColosis", 300);

    //patient.CheckOut(100);
    //patient.Summary();
    patients.Add(patient);
    patient.GenerateReport(patients);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

