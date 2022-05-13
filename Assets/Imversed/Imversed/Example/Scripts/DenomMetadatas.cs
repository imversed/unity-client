using System.Collections.Generic;

namespace models {
    [System.Serializable]
    public class Denom
    {
        public int exponent;
        public string denom;
        public List<string> aliases;
    }

    [System.Serializable]
    public class DenomMetadatas
    {
        public List<DenomMetadata> metadatas;
    }

    [System.Serializable]
    public class DenomMetadata
    {
        public string description;
        public string display;
        public string name;
        public string symbol;
        public List<Denom> denomUnits;
    }
}