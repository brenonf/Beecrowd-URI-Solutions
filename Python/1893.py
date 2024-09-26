lua = list(map(int, input().split()))
a = lua[0]
b = lua[1]

if 0 <= b <= 2:
    print("nova")
elif 3 <= b <= 96 and b > a:
    print("crescente")
elif 97 <= b <= 100:
    print("cheia")
elif 3 <= b <= 96 and b < a:
    print("minguante")
