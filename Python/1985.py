def entrada():
    n = int(input())
    x = list()
    for i in range(n):
        a = input().split()
        x.append(a)
    return x

def preco(x):
    comanda = 0
    for i in range(len(x)):
        if x[i][0] == '1001':
            comanda += int(x[i][1]) * 1.50
        elif x[i][0] == '1002':
            comanda += int(x[i][1]) * 2.50
        elif x[i][0] == '1003':
            comanda += int(x[i][1]) * 3.50
        elif x[i][0] == '1004':
            comanda += int(x[i][1]) * 4.50
        elif x[i][0] == '1005':
            comanda += int(x[i][1]) * 5.50

    return comanda

def main():
    print('{:.2f}'.format(preco(entrada())))

main()
        