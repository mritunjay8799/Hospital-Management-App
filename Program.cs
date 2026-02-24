using Hospital_Management_App.Class;

/*

1. Create a `Patient` class. Keep `name`, `age`, `bloodType`, `medicalHistory` private. Expose getters(read value) for each and add 
`addDiagnosis(entry)`. Print a formatted patient summary to the console.

2. Add validation in setters: age must be 0–150, bloodType from a fixed list. Throw descriptive errors on bad input. 
Test with invalid data and confirm errors are caught gracefully.

 */

try
{
    Patient patient = new Patient("Mahesh", "A+");
    patient.Age = 200;
    patient.AddDiagnosis("Malaria");
    patient.AddDiagnosis("TuberColosis");

    patient.Summary();
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

