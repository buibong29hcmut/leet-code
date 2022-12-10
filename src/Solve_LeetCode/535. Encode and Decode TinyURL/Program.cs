using System.Text;

public class Codec
{
    private string seed = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private readonly Dictionary<string,string> LongToShortUrl= new Dictionary<string, string>();
    private readonly Dictionary<string, string> ShortToLongUrl = new Dictionary<string, string>();

    public string encode(string longUrl)
    {
        string result = "";
        bool IsNotBreak=true;
        if (LongToShortUrl.ContainsKey(longUrl))
        {
            return LongToShortUrl[longUrl];
        }
        while (IsNotBreak)
        {
             result = GenerateUrl();
            if(!ShortToLongUrl.ContainsKey(result))
            {
                LongToShortUrl.Add(longUrl, result );
                ShortToLongUrl.Add(result, longUrl);
                IsNotBreak = false; 
            }
        }
        return result;
    }
    public string GenerateUrl()
    {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < 6; i++)
        {
            result.Append(seed[new Random().Next(0, seed.Length)]);
        }
        return result.ToString();
    }
    // Decodes a shortened URL to its original URL.
    public string decode(string shortUrl)
    {
        string result = "";
        if(ShortToLongUrl.ContainsKey(shortUrl))
        {
            result = ShortToLongUrl[shortUrl];  
        }
        return result;
    }
}