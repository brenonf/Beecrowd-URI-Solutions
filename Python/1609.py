n = int(input())
for _ in range(n):
    input()
    listao = list(map(int, input().split()))
    print(len(set(listao)))
