namespace LibrairieConversionNote
{
    public class ConversionAlphabetiqueToNote
    {
    public string Transformer(string alpha)
        {
            alpha=alpha.ToUpperInvariant();
            if (alpha == "A") 
            {
                return "LA";
            }
            else if (alpha == "B")
            {
                return "SI";
            }
            else if (alpha == "C")
            {
                return "DO";
            }
            else if (alpha == "D")
            {
                return "RE";
            }
            else if (alpha == "E")
            {
                return "MI";
            }
            else if (alpha == "F")
            {
                return "FA";
            }
            else if (alpha == "G")
            {
                return "SOL";
            }
            else
            {
                return "Choix invalide. Choissisez un lettre entre A et G.";
            }
            
        }
    }
}



