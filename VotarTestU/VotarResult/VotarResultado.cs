using VotarTestU;

namespace VotarResult
{
	public class VotarResultado
	{
		[Fact]
		public void NaoPode()
		{
			int idade = 9;
			string esperado = "N�o � permitido votar!";
			string obtido = VotarTest.PodeVotar(idade);
			Assert.Equal(esperado, obtido);
		}

		[Fact]
		public void OpcionalJovem()
		{
			int idade = 17;
			string esperado = "O voto n�o � obrigat�rio!";
			string obtido = VotarTest.PodeVotar(idade);
			Assert.Equal(esperado, obtido);
		}

		[Fact]
		public void Pode()
		{
			int idade = 24;
			string esperado = "O voto obrigat�rio!";
			string obtido = VotarTest.PodeVotar(idade);
			Assert.Equal(esperado, obtido);
		}

		[Fact]
		public void OpcionalIdoso()
		{
			int idade = 84;
			string esperado = "O voto � facultativo!";
			string obtido = VotarTest.PodeVotar(idade);
			Assert.Equal(esperado, obtido);
		}
	}
}