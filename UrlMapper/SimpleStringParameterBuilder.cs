using System.Collections.Generic;

namespace UrlMapper
{
    public class SimpleStringParameterBuilder : ISimpleStringParameterBuilder
    {
        public ISimpleStringParameter Parse(string pattern)
        {
            // TODO: Need to implement this method.
            return new xx();
        }
    }

    public class xx : ISimpleStringParameter
    {
        public void ExtractVariables(string target, IDictionary<string, string> dicToStoreResults)
        {
            throw new System.NotImplementedException();
        }

        public bool IsMatched(string textToCompare)
        {
            throw new System.NotImplementedException();
        }
    }
}