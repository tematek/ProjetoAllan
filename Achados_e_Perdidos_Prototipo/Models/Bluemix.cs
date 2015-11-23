using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Achados_e_Perdidos_Prototipo
{
	public class Bluemix
	{

		public string RetornaRespostaFaq(string topclass)
		{
			string RespostaFaq = "";

			switch (topclass)
			{
				case "perdi":
					RespostaFaq = "Caso você tenha perdido um item, siga os seguintes passos: 1º) Faça seu cadastro caso não tenha; 2º) Clique em PERDI e veja se alguém já encontrou e cadastrou o objeto que você perdeu; 3º) Caso não tenha o registro do item, clique em CADASTRAR e preencha o formulário";
					break;
				case "senha":
					RespostaFaq = "Se você esqueceu sua senha, clique em Entrar e selecione ESQUECI MINHA SENHA. Preencha com o seu e-mail e aguarde nosso contato.";
					break;
				case "leipena":
					RespostaFaq = "Não devolver um objeto num prazo de 15 dias é considerada “apropriação de coisa achada”, cuja pena é de detenção de um mês a um ano ou multa, de acordo com o art. 169 do Código Penal";
					break;
				case "encontrei":
					RespostaFaq = "Caso você tenha encontrado um item, siga os seguintes passos: 1º) Faça seu cadastro caso não tenha; 2º) Clique em ENCONTREI e veja se alguém já cadastrou o objeto e se a localização registrada coincide. Caso sim, entre em contato com a pessoa para devolver o item; 3º) Caso não tenha o registro do item, clique em CADASTRAR e preencha o formulário";
					break;

				case "doacao":
					RespostaFaq = "Para contribuir com nosso projeto você poderá doar qualquer quantia através do link CONTRIBUA. Sua contribuição será importante para mantermos as atividades do site.";
					break;

				default:
					RespostaFaq = "Desculpe, não entedi sua dúvida.";
					break;


			}

			return RespostaFaq;
		}

	}
}