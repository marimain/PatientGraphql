using System.Collections.Generic;
using GraphQL.Types;

namespace StarWars.Types;
internal class PatientType : ObjectGraphType<Patient>
{
    public PatientType()
    {
        Name = "Patient";

        Field(h => h.Id).Description("The id of the patient.");
        Field(h => h.FirstName, nullable: true).Description("The first name of the patient.");
        Field(h => h.LastName, nullable: true).Description("The last name of the patient.");

    }
}

