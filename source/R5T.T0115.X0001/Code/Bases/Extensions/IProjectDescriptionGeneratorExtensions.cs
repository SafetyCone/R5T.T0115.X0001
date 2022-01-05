using System;

using R5T.T0115;


namespace System
{
    public static class IProjectDescriptionGeneratorExtensions
    {
        public static string GetConstructionProjectDescription(this IProjectDescriptionGenerator _,
           string libraryDescription)
        {
            var output = $"Construction project for {libraryDescription}.";
            return output;
        }
    }
}
