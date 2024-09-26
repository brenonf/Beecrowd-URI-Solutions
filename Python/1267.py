while True:
    line = input().strip()
    if not line:
        continue

    n = list(map(int, line.split()))
    if n[0] == 0 and n[1] == 0:
        break

    alunos = [0] * n[0]

    for _ in range(n[1]):
        lista = list(map(int, input().strip().split()))
        for j in range(len(lista)):
            alunos[j] += lista[j]

    yes = any(i == n[1] for i in alunos)

    if yes:
        print("yes")
    else:
        print("no")
