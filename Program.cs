using Hospital_Management_App.Class;
/*
Build: Hospital Management Console

You're the sole developer hired by City General Hospital. They manage everything on paper and want a digital system. 
Across 5 principles, you'll build their complete console app — admitting patients, assigning staff, running daily rounds, 
and printing reports. Each principle unlocks a new chapter of the system.
*/


/*

 Create a `Patient` class. Keep `name`, `age`, `bloodType`, `medicalHistory` private. Expose getters(read value) for each and add 
`addDiagnosis(entry)`. Print a formatted patient summary to the console.

 */

Patient patient = new Patient("Mahesh", 45, "A+");
patient.AddDiagnosis("Malaria");
patient.AddDiagnosis("TuberColosis");

patient.Summary();
