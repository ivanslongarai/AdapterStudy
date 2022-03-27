using AdapterStudy.Entities;
using AdapterStudy.Adapters.Interfaces;

namespace AdapterStudy.Adapters;

public class TeamInformationAdapter : ITeamInformationAdapter
{
    public TeamInformation ConvertTeamInformation(Technician technician, FourthOfficial fourthOfficial)
    {
        return new TeamInformation(technician.Name, fourthOfficial.Name, technician.Team.ToList());
    }

}