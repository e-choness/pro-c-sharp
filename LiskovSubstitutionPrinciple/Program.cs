// See https://aka.ms/new-console-template for more information

using SolidLibrary.Interfaces;
using SolidLibrary.Models;
using SolidLibrary.Services;

// Start with Personnel System welcome message
StandardMessager.PersonnelSystemStartMessage();

StandardMessager.SeparatorMessage();

// A store overseer's information
StoreOverseer storeOverseer = new();
storeOverseer.FirstName = "Jane";
storeOverseer.LastName = "Dude";
storeOverseer.Team = new();

// A store supervisor's information
StoreSupervisor storeSupervisor = new();
storeSupervisor.FirstName = "John";
storeSupervisor.LastName = "Doe";
storeSupervisor.Team = new();
storeSupervisor.AssignManager(storeOverseer);

// A store receptionist's informaetion
Receptionist receptionist = new();
receptionist.FirstName = "Jon";
receptionist.LastName = "Gill";
receptionist.AssignManager(storeSupervisor);

// Team assignment
storeOverseer.AssignTeam(storeSupervisor);
storeSupervisor.AssignTeam(receptionist);

// Give corresponding salary
storeOverseer.Salary = 8500.00f;
storeSupervisor.Salary = 7000.00f;
receptionist.Salary = 6000.00f;

// Get hourly rate
storeOverseer.CalculateHourlyRate();
storeSupervisor.CalculateHourlyRate();
receptionist.CalculateHourlyRate();

// Give weekly reports
storeOverseer.GenerateWeeklyReport();
storeSupervisor.GenerateWeeklyReport();

// End the system with goodbye message
StandardMessager.PersonnelSystemEndMessage();