using System.Security.Cryptography;

namespace ProvaPub.Services
{
	public class RandomService
	{
		public int GetRandom()
		{
            //returns a random integer between 0 (inclusive) and 1001 (exclusive)
            return RandomNumberGenerator.GetInt32(1001);
        }

	}
}
