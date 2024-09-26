def contador(array):
    return array.count(1)

def contador_zero(array):
    return array.count(0)

def main():
    import sys
    input = sys.stdin.read
    data = input().splitlines()

    index = 0
    while index < len(data):
        line = data[index]
        if not line.strip():
            break
        n, m = map(int, line.split())
        
        if n == 0 and m == 0:
            break

        cont = 4
        lista = []

        for i in range(n):
            index += 1
            lista.append(list(map(int, data[index].split())))

        for linha in lista:
            if contador(linha) == m:
                cont -= 1
                break

        problema = [0] * m
        for linha in lista:
            for j in range(m):
                if linha[j] == 1:
                    problema[j] += 1

        if 0 in problema:
            cont -= 1

        if any(p == n for p in problema):
            cont -= 1

        for linha in lista:
            if contador_zero(linha) == m:
                cont -= 1
                break

        print(cont)
        index += 1

if __name__ == "__main__":
    main()
