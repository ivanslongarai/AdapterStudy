using AdapterStudy.Adapters;
using AdapterStudy.Entities;

var technician = new Technician("Mark");
var fourthOfficial = new FourthOfficial("Smith");

TeamInformation adapterReult = new TeamInformationAdapter()
    .ConvertTeamInformation(
        technician,
        fourthOfficial
    );

Console.WriteLine(adapterReult.ToString());