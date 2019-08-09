using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesteConquest.Domain.Utils;

namespace TesteConquest.Domain.Entities
{
    public class Autor
    {
        public int Id { get; private set; }

        public string NomeCompleto { get; private set; }

        public string NomeExibicao { get; private set; }

        protected Autor()
        {

        }

        public Autor(int id, string nomeCompleto)
        {
            Id = id;
            NomeCompleto = nomeCompleto;
            NomeExibicao = NomeFormatado(nomeCompleto);
        }

        public static string NomeFormatado(string nameString)
        {
            string[] validacao1 = {"da", "de", "do", "das", "dos"};
            string[] validacao2 = {"Filho", "Filha", "Neto", "Neta", "Sobrinho", "Sobrinha", "Junior"};

            var nomes = nameString.ToLower().Split(' ').ToList();

            for (int i = 0; i < nomes.Count; i++)
            {
                if (!validacao1.Contains(nomes[i]))
                {
                    nomes[i] = StringUtils.ToTitleCase(nomes[i]);
                }
            }

            if (nomes.Count > 1)
            {
                if (nomes.Count == 2)
                {
                    return $"{nomes.Last().ToUpper()}, {nomes.First()}";
                }
                else
                {
                    string nomeFinal;
                    string sobrenomeFinal;

                    if (validacao2.Contains(nomes.Last()))
                    {
                        sobrenomeFinal = $"{nomes[nomes.Count - 2]} {nomes.Last()}";
                        nomes.RemoveRange(nomes.Count - 2, 2);
                        nomeFinal = String.Join(" ", nomes);

                        return $"{sobrenomeFinal.ToUpper()}, {nomeFinal}";
                    }
                    else
                    {
                        sobrenomeFinal = nomes.Last();
                        nomes.RemoveRange(nomes.Count - 1, 1);
                        nomeFinal = String.Join(" ", nomes);

                        return $"{sobrenomeFinal.ToUpper()}, {nomeFinal}";
                    }
                }
                
            }
            else
            {
                return $"{nomes.First().ToUpper()}";
            }

        }


    }
}
