class Pais:
    def __init__(self, nome, ouro, prata, bronze):
        self.nome = nome
        self.ouro = ouro
        self.prata = prata
        self.bronze = bronze
def main():
    n = int(input())

    paises = []
    for _ in range(n):
        dados = input().split()
        nome = dados[0]
        ouro = int(dados[1])
        prata = int(dados[2])
        bronze = int(dados[3])
        paises.append(Pais(nome, ouro, prata, bronze))

    paisesOrdenados = sorted(paises, key=lambda p: (-p.ouro, -p.prata, -p.bronze, p.nome))

    for pais in paisesOrdenados:
        print(f"{pais.nome} {pais.ouro} {pais.prata} {pais.bronze}")

if __name__ == "__main__":
    main()
