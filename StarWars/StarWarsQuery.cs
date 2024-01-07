using System;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Types;
using StarWars.Types;

namespace StarWars;

public class StarWarsQuery : ObjectGraphType<object>
{
    public StarWarsQuery(StarWarsData data)
    {
        Name = "Query2";

        FieldAsync<CharacterInterface>("hero", resolve: async context => await data.GetDroidByIdAsync("3"));
        FieldAsync<HumanType>(
            "human",
            arguments: new QueryArguments(
                new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "id", Description = "id of the human" }
            ),
            resolve: async context => await data.GetHumanByIdAsync(context.GetArgument<string>("id"))
        );

        Func<IResolveFieldContext, string, Task<Droid>> func = (context, id) => data.GetDroidByIdAsync(id);

        FieldDelegate<DroidType>(
            "droid",
            arguments: new QueryArguments(
                new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "id", Description = "id of the droid" }
            ),
            resolve: func
        );
        FieldAsync<PatientType>(
          "patient",
            arguments: new QueryArguments(
                new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "id", Description = "id of the patient" }
            ),
            resolve: async context => await data.GetPatient(context.GetArgument<string>("id"))
            );
        FieldAsync<ListGraphType<PatientType>>(
            "patients",
            resolve:
                async context => await data.Patients()
            );
        ;

    }
}
