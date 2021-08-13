namespace CSHARP.Generics
{
    public class RefComparison
    {
        public static bool AreReferenceEqual<T>(T first, T second) where T : class{
            return first == second;
        }
    }
}