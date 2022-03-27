using AdapterStudy.Entities;

namespace AdapterStudy.Adapters.Interfaces;

public interface ITeamInformationAdapter
{
    TeamInformation ConvertTeamInformation(Technician technician, FourthOfficial fourthOfficial);
}