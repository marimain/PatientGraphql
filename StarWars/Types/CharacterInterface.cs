
using GraphQL.Types;

namespace StarWars.Types;

public class CharacterInterface : InterfaceGraphType<StarWarsCharacter>
{
    public CharacterInterface()
    {
        Name = "Character";

        Field(d => d.Id).Description("The id of the character.");
        Field(d => d.Name, nullable: true).Description("The name of the character.");

        Field<ListGraphType<CharacterInterface>>("friends");
        Field<ListGraphType<EpisodeEnum>>("appearsIn", "Which movie they appear in.");
    }

}
public class PatientsInterface : InterfaceGraphType<Patient>
{
    public PatientsInterface()
    {
        Name = "Patients";

        Field(d => d.Id).Description("The id of the Patient.");
        Field(d => d.FirstName, nullable: true).Description("The name of the Patient.");
        Field(d => d.LastName, nullable: true).Description("The name of the Patient.");
    }
}
