namespace VotarTestU
{
	public class VotarTest
	{
		public static string PodeVotar(int idade)
		{
			if (idade <= 15)
				return "Não é permitido votar!";

			if ((idade >= 16 && idade <= 17))
				return "O voto não é obrigatório!";

			if ((idade >= 18 && idade <= 70))
				return "O voto obrigatório!";

			return "O voto é facultativo!";
		}
	}
}
