using System;

using R5T.T0115;


namespace System
{
    public static class IProjectDescriptionGeneratorExtensions
    {
        [Obsolete("See R5T.O0007.IProjectDescriptionOperations.Get_ConstructionProjectDescription()")]
        public static string GetConstructionProjectDescription(this IProjectDescriptionGenerator _,
           string libraryDescription)
        {
            var output = $"Construction project for {libraryDescription}.";
            return output;
        }
    }
}
