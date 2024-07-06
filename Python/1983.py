def entrada():
    n = int(input())
    x= list()
    for i in range(n):
        a = input().split()
        x.append(a)
    return x

def melhor(x):
    nota = 1
    aluno = 0
    for i in range(len(x)):
        if float(x[i][1]) > float(nota):
            nota = x[i][1]
            aluno = x[i][0]
    if float(nota) <8:
        print('Minimum note not reached')
    else:
        print(aluno)

def main():
    melhor(entrada())

main()
