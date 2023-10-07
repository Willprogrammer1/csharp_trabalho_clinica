using System;

namespace terminal_clinica
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pacientes
            int countPaciente = 1;
            string nomePaciente = "";
            int idadePaciente;


            // Profissionais
            string nomeProfissional;
            string especialidadeProfissional;
            int tempoExperiencia;

            int qtdProfissionaisAte10AnosExperiencia = 0;
            int totalExperienciaProfissionalAte10Anos = 0;

            int qtdProfissionais11a20AnosExperiencia = 0;
            int totalExperienciaProfissional11a20Anos = 0;

            int qtdProfissionaisMaior20AnosExperiencia = 0;
            int totalExperienciaProfissionalMaior20Anos = 0;


            Console.Clear();
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine($"-----Bem-vindo ao melhor software de gestão de clínicas médicas!-------");
            Console.WriteLine("-----------------------------------------------------------------------");

            Console.Write("Quantos profissionais trabalham na clínica? ");
            int numerosProfissionais = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numerosProfissionais; i++)
            {
                Console.Clear();
                Console.WriteLine("------------------------------------");
                Console.WriteLine($"-----Cadastro de profissional-------");
                Console.WriteLine("------------------------------------");

                Console.Write($"Qual o nome profissional {i}? ");
                nomeProfissional = Console.ReadLine();

                Console.Write($"Qual a especialidade de {nomeProfissional}? ");
                especialidadeProfissional = Console.ReadLine();

                Console.Write($"Qual o tempo de experiência de {nomeProfissional}? ");
                tempoExperiencia = int.Parse(Console.ReadLine());


                if (tempoExperiencia <= 10)
                {
                    qtdProfissionaisAte10AnosExperiencia++;
                    totalExperienciaProfissionalAte10Anos += tempoExperiencia;
                }
                else if (tempoExperiencia <= 20)
                {
                    qtdProfissionais11a20AnosExperiencia++;
                    totalExperienciaProfissional11a20Anos += tempoExperiencia;
                }
                else if (tempoExperiencia > 20)
                {
                    qtdProfissionaisMaior20AnosExperiencia++;
                    totalExperienciaProfissionalMaior20Anos += tempoExperiencia;
                }

                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine($"-----Cadastro de pacientes atendidos por este profissional----------");
                Console.WriteLine("--------------------------------------------------------------------");

                do
                {
                    Console.Write($"Qual o nome do paciente {countPaciente}? ");
                    nomePaciente = Console.ReadLine();

                    if (nomePaciente != "fim")
                    {
                        Console.Write($"Qual a idade do paciente {nomePaciente}? ");
                        idadePaciente = int.Parse(Console.ReadLine());
                        countPaciente++;
                    }

                    Console.WriteLine("---------");
                } while (nomePaciente != "fim");

            }
        }
    }
}
