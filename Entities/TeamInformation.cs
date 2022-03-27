using System.Text;
namespace AdapterStudy.Entities;

public class TeamInformation : Entity
{
    public TeamInformation(string technician, string fourthOfficial, List<Player> team)
    {
        Technician = technician;
        FourthOfficial = fourthOfficial;
        Team = team;
    }

    public string Technician { get; private set; }
    public string FourthOfficial { get; private set; }
    public IReadOnlyCollection<Player> Team { get; private set; }

    public override string ToString()
    {
        var stringBuilder = new StringBuilder();

        stringBuilder.AppendLine("--------------------------------------------------------------");
        stringBuilder.AppendLine("Team information");
        stringBuilder.AppendLine("--------------------------------------------------------------");
        stringBuilder.AppendLine("");
        stringBuilder.AppendLine($"Technician: {Technician}");
        stringBuilder.AppendLine($"FourthOfficial: {FourthOfficial}");
        stringBuilder.AppendLine("");
        stringBuilder.AppendLine("Players playing");
        foreach (var player in Team.Where(x => x.IsPlaying == true))
            stringBuilder.AppendLine($"   Player: {player.Name}");
        stringBuilder.AppendLine("");
        stringBuilder.AppendLine("Players waiting");
        foreach (var player in Team.Where(x => x.IsPlaying == false))
            stringBuilder.AppendLine($"   Player: {player.Name}");
        stringBuilder.AppendLine("");
        stringBuilder.AppendLine("--------------------------------------------------------------");
        return stringBuilder.ToString();
    }

}