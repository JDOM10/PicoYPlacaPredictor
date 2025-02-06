# Name: PicoYPlacaPredictor
Description: This proyect implements how the system of "Pico y Placa" works in Quito, Ecuador. It depends on the last digit number of the plate also the day and the hour if a car can drive or not.

# Characteristics: 
- Model Vehicle: Represents a vehicle with its plate number and last digit.
- Rules Restrictions: Define the schedule and the restrictions to drive.

# Technologies Used
- Language: C#
- Paradigm: Object-oriented programming (OOP)
- Versioning: Git and GitHub
- Testing: Tests with xUnit

# Compilation and Execution for Test

To correctly compile and run the project, ensure that the entry point is set to `Program.cs`.  
If you encounter an error related to multiple entry points (`CS0017`), use the following command:

```bash
dotnet clean
dotnet build /property:StartupObject=PicoYPlacaApp.Program
dotnet test
