using System;
using System.Linq;

class URI {
    static void Main(string[] args) {
        string input;

        while ((input = Console.ReadLine()) != null) {
            if (string.IsNullOrWhiteSpace(input)) break;

            int[] n = input.Split().Select(int.Parse).ToArray();
            int jogos = n[0];
            int vitMaisUma = n[1];
            int[][] resultados = new int[jogos][];

            for (int i = 0; i < jogos; i++) {
                resultados[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }

            Array.Sort(resultados, (a, b) => (a[1] - a[0]).CompareTo(b[1] - b[0]));

            for (int i = 0; i < jogos; i++) {
                int diferenca = resultados[i][1] - resultados[i][0];

                if (diferenca == 0 && vitMaisUma > 0) {
                    resultados[i][0]++;
                    vitMaisUma--;
                } 
                else if (diferenca > 0) {
                    if (vitMaisUma >= diferenca + 1) {
                        resultados[i][0] += diferenca + 1;
                        vitMaisUma -= (diferenca + 1);
                    } else if (vitMaisUma >= diferenca) {
                        resultados[i][0] += diferenca;
                        vitMaisUma -= diferenca;
                    }
                }
            }

            for (int i = 0; i < jogos; i++) {
                if (resultados[i][1] == resultados[i][0] && vitMaisUma > 0) {
                    resultados[i][0]++;
                    vitMaisUma--;
                }
            }

            int pontos = 0;
            for (int i = 0; i < jogos; i++) {
                if (resultados[i][0] > resultados[i][1]) {
                    pontos += 3;
                } else if (resultados[i][0] == resultados[i][1]) {
                    pontos += 1;
                }
            }

            Console.WriteLine(pontos);
        }
    }
}
